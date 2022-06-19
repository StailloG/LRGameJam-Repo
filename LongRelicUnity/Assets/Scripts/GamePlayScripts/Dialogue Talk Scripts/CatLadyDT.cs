using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLadyDT : DialogueTalk
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set withoutLadder;
    [SerializeField] private Dialogue_Set withLadder;
    [SerializeField] private Dialogue_Set finalSentence;

    public enum DialogueState { intro, woLadder, wLadder, saveCat, final } //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
    public DialogueState state;

    // Start is called before the first frame update
    void Start()
    {
        state = DialogueState.intro;//this is how you can change/set state. make sure at start it is set to intro
                                       //in other scripts is where you would use "FindObjectOfType<BlockStopEmployeeDT>().state = DialogueState.action" to change states
    }

    public override void Talk()
    {
        //logic here to determine what to say 
        //using enum to do that 
        switch (state)
        {
            case DialogueState.intro:
                IntroDialogue();   //this is from the inherited DialogueTalk Class  
                state = DialogueState.woLadder;
                FindObjectOfType<SFXPlayer>().PlayCat();
                break;


            case DialogueState.woLadder:

                withoutLadder?.sendDialogue();
                break;

              
            case DialogueState.wLadder://this is from this class, 
                withLadder?.sendDialogue();
                break;

            case DialogueState.saveCat:
                finalSentence?.sendDialogue();
                var source = FindObjectOfType<AdvancedMusicPlayer>().stem4;
                StartCoroutine(FindObjectOfType<AdvancedMusicPlayer>().StartFade(source, 3.333f, 1.0f, 0.0f));
                FindObjectOfType<ToDoListManager>().FoundMouse(); 
                break; 

        }
    }
}
