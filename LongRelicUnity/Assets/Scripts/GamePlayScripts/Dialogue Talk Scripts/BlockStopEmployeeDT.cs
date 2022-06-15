using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStopEmployeeDT : DialogueTalk //inheriting from dialogue talk, every person will have a garanteed intro and final dialogue 
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set askForXBox;


    public enum DialogueState { intro, action, final} //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
    public DialogueState state; 
    private void Start()
    {
        state = DialogueState.intro;//this is how you can change/set state. make sure at start it is set to intro
                                    //in other scripts is where you would use "FindObjectOfType<BlockStopEmployeeDT>().state = DialogueState.action" to change states 
    }

    public override void Talk()
    {
        //logic here to determine what to say 
        //using enum to do that 
        switch(state)
        {
            case DialogueState.intro:
                IntroDialogue();   //this is from the inherited DialogueTalk Class  
                break; 

            case DialogueState.action://this is from this class, 
                askForXBox?.sendDialogue();
                FindObjectOfType<ScammerDT>().state = ScammerDT.DialogueState.action;//change dialogue state of scammer 
                state = DialogueState.final; //go to final state
                break;

            case DialogueState.final:
                FinalDialogue();//this is from the inherited DialogueTalk Class
                break; 
        }


    }
}
