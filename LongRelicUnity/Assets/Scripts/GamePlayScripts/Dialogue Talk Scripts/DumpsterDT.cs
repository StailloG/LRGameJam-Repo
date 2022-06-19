using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpsterDT : DialogueTalk
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set ladder;
    [SerializeField] private Dialogue_Set monitor;
    [SerializeField] private Dialogue_Set final;

    [SerializeField] private SpriteRenderer sr; 
    [SerializeField] private Sprite sprite;
    private bool inArea = false;

    public enum DialogueState { intro, getLadder, getMonitor, final } //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
    public DialogueState state;

    // Start is called before the first frame update
    void Start()
    {
        state = DialogueState.intro;//this is how you can change/set state. make sure at start it is set to intro
                                    //in other scripts is where you would use "FindObjectOfType<BlockStopEmployeeDT>().state = DialogueState.action" to change states
    }

 

    private void Update()
    {
      
       
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space) && !Textbox.On)
        {         
            Talk();
        }

    }
    public override void Talk()
    {
        //logic here to determine what to say 
        //using enum to do that 
       
        if (state == DialogueState.getLadder)
        {
            
            ladder?.sendDialogue();
            state = DialogueState.getMonitor;
            var ladderGO = FindObjectOfType<Ladder>();
            Destroy(ladderGO.gameObject);
            FindObjectOfType<SFXPlayer>().PlayTrash();
            FindObjectOfType<CatLadyDT>().state = CatLadyDT.DialogueState.wLadder;
            return; 
        }

        if (state == DialogueState.getMonitor)
        {
            monitor?.sendDialogue();
            state = DialogueState.final;
            FindObjectOfType<ToDoListManager>().FoundMonitor();
            FindObjectOfType<SFXPlayer>().PlayTrash();

            sr.sprite = sprite;
            return; 
        }

        if (state == DialogueState.final)
        {
            final?.sendDialogue();
            var source = FindObjectOfType<AdvancedMusicPlayer>().stem3;
            StartCoroutine(FindObjectOfType<AdvancedMusicPlayer>().StartFade(source, 3.333f, 1.0f, 0.0f));
            return; 
        }


    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inArea = true;
        if (state == DialogueState.intro)
        {
            IntroDialogue();
            state = DialogueState.getLadder;
        }
            
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }
}
