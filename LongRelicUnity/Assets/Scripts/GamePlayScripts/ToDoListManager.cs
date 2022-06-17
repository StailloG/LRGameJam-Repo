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
    [SerializeField] private GameObject item4UISlash;

    private bool item5Found = false;//???
    [SerializeField] private GameObject item5UISlash;


    [SerializeField] private GameObject toDoPanel;

    // Start is called before the first frame update
    void Start()
    {
        item1UISlash.gameObject.SetActive(false);
        item2UISlash.gameObject.SetActive(false);
        item3UISlash.gameObject.SetActive(false);
        item4UISlash.gameObject.SetActive(false);
        item5UISlash.gameObject.SetActive(false);

        toDoPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoundItem1()
    {
        item1Found = true;
    }

    public void FoundItem2()
    {
        item2Found = true;
    }

    public void FoundItem3()
    {
        item3Found = true;
    }

    public void FoundItem4()
    {
        item4Found = true;
    }

    public void FoundItem5()
    {
        item5Found = true;
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
            item4UISlash.SetActive(true);


        if (item5Found)
            item5UISlash.SetActive(true);

    }

    public void CloseTodoPanel()
    {
        toDoPanel.SetActive(false);
    }


}
