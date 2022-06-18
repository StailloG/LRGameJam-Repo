using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpsterDT : DialogueTalk
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set ladder;
    [SerializeField] private Dialogue_Set monitor;
    [SerializeField] private Dialogue_Set final;

    private bool inArea = false;

    public enum DialogueState { intro, getLadder, getMonitor, final } //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
    public DialogueState state;

    // Start is called before the first frame update
    void Start()
    {
        state = DialogueState.intro;//this is how you can change/set state. make sure at start it is set to intro
                                    //in other scripts is where you would use "FindObjectOfType<BlockStopEmployeeDT>().state = DialogueState.action" to change states
    }

    private void OnMouseDown()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.point);
        }
    }
    public override void Talk()
    {
        //logic here to determine what to say 
        //using enum to do that 
        switch (state)
        {
           

            case DialogueState.getLadder:
                ladder?.sendDialogue();
                break;

            case DialogueState.getMonitor://this is from this class, 
                monitor?.sendDialogue();
                break;

            case DialogueState.final://this is from this class, 
                final?.sendDialogue();
                break;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        inArea = true;
        if (state == DialogueState.intro)
        {
            IntroDialogue();
        }
            
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }
}
