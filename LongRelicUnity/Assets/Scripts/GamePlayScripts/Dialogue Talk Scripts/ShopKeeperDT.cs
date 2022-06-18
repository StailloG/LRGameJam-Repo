using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperDT : DialogueTalk
{
    //if person has extra dialogue, you would add them here 
    [SerializeField] private Dialogue_Set collectCoins;
    [SerializeField] private Dialogue_Set transaction;
    [SerializeField] private Dialogue_Set finalSentence;

    public GameObject keyboard;
    public bool hasKeyboard = false; //public for CoinManagement script

    public enum DialogueState { intro, collectingCoins, transactioning, final } //these are the potential dialogue states the character can be in, you can add more states if you need more dialogue
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
                state = DialogueState.collectingCoins;
                FindObjectOfType<CoinManagement>().openCoins(); //open coinmanagment script
                StartCoroutine(FindObjectOfType<CoinManagement>().coinsObtainedAppear());
                break;

            case DialogueState.collectingCoins://this is from this class, 
                collectCoins?.sendDialogue();
                break;

            case DialogueState.transactioning:
                transaction?.sendDialogue();
                Destroy(keyboard);
                hasKeyboard = true;
                state = DialogueState.final;
                FindObjectOfType<ToDoListManager>().FoundKeyboard(); 
                break;

            case DialogueState.final:
                finalSentence?.sendDialogue();
                break;
        }


    }
}
