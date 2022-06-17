using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private bool inArea = false; 
    // Start is called before the first frame update
    void Start()
    {
        //text object that says "press space" set inactive
    }

    // Update is called once per frame
    void Update()
    {
        if(inArea && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<CatLadyDT>().state = CatLadyDT.DialogueState.wLadder;
            Destroy(this.gameObject);
        }

        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            inArea = true; 
            //text object that says "press space" set active
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            inArea = false;
            //text object that says "press space" set inactive
        }
    }
}
