using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInTree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       var catLady =  FindObjectOfType<CatLadyDT>(); 
        if(catLady.state == CatLadyDT.DialogueState.wLadder)
        {
            catLady.state = CatLadyDT.DialogueState.saveCat;
        }

    }
}
