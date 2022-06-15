using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePete : MonoBehaviour
{
    [SerializeField] private string dialogue;
    private bool inArea;
    public Text textBox;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inArea)
            {
               
                //set text object active
                textBox.gameObject.SetActive(true);
                //assign the text 
                textBox.text = dialogue;
            }
        }

        if(!inArea)
            textBox.gameObject.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inArea = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inArea = false;
          
        }
    }
}
