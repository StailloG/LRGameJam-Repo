using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackBlockDT : DialogueTalk
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set notEnoughParts;
    [SerializeField] private Dialogue_Set allParts;

    public enum DialogueState { intro, mid, final } //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
    public DialogueState state;

    // Start is called before the first frame update
    void Start()
    {
        state = DialogueState.mid;//this is how you can change/set state. make sure at start it is set to intro
        IntroDialogue();                        //in other scripts is where you would use "FindObjectOfType<BlockStopEmployeeDT>().state = DialogueState.action" to change states
    }

    public override void Talk()
    {
        //logic here to determine what to say 
        //using enum to do that 
        switch (state)
        {
            case DialogueState.intro:
                IntroDialogue();   //this is from the inherited DialogueTalk Class 
                state = DialogueState.mid;
                break;

            case DialogueState.mid:
                notEnoughParts?.sendDialogue();
               
                break;

            case DialogueState.final:
                allParts?.sendDialogue();
                StartCoroutine(NextLvl());
                break;

        }
    }

    public IEnumerator NextLvl()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(2);
    }
}