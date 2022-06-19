using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInTree : DialogueTalk
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space) && !Textbox.On)
        {
            var catLady = FindObjectOfType<CatLadyDT>();
            if (catLady.state == CatLadyDT.DialogueState.wLadder)
            {
                catLady.state = CatLadyDT.DialogueState.saveCat;
            }
        }
    }

    private void OnMouseDown()
    {
      

    }
}
