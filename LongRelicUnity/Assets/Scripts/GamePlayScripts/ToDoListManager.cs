using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoListManager : MonoBehaviour
{
    private bool item1Found = false; //monitor 
    [SerializeField] private GameObject item1UISlash; 


    private bool item2Found = false; // graphics card 
    [SerializeField] private GameObject item2UISlash;

    private bool item3Found = false; // keyboard
    [SerializeField] private GameObject item3UISlash;

    private bool item4Found = false;//???
    [SerializeField] private GameObject HardDriveUI;


    [SerializeField] private GameObject toDoPanel;

    // Start is called before the first frame update
    void Start()
    {
        item1UISlash.gameObject.SetActive(false);
        item2UISlash.gameObject.SetActive(false);
        item3UISlash.gameObject.SetActive(false);
        HardDriveUI.gameObject.SetActive(false);

        toDoPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Testing to make using keyboard input to make sure it works 

       


    }

    public void FoundKeyboard()
    {
        item1Found = true;
    }

    public void FoundMouse()
    {
        item2Found = true;
    }

    public void FoundMonitor()
    {
        item3Found = true;
    }

    public void FoundHardDrive()
    {
        item4Found = true;
    }


    public bool IsAllItemsFound()
    {
        if (item1Found && item2Found && item3Found && item4Found)
        {
            FindObjectOfType<BlackBlockDT>().state = BlackBlockDT.DialogueState.final;
            //"Oh I can go back to my friend now" 
            //finishItems?.sendDialogue(); 
        }
           
       
        return item1Found && item2Found && item3Found && item4Found;
    }    


    public void OpenTodoPanel()
    {
        toDoPanel.SetActive(true);


        if(item1Found)
            item1UISlash.SetActive(true);


        if (item2Found)
            item2UISlash.SetActive(true);


        if (item3Found)
            item3UISlash.SetActive(true);


        if (item4Found)
            HardDriveUI.SetActive(true);


    }

    public void CloseTodoPanel()
    {
        toDoPanel.SetActive(false);
    }


}
