using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //variables
    public int coinCounter = 0;
    public bool pickUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pickUp == true)
        {
            coinCounter += 1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player2")
        {
            pickUp = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickUp = false;
    }
}
