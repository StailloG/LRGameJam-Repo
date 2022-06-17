using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject ladder;

    [Header("Bools")]
    [SerializeField] private bool hasLadder = false;
    [SerializeField] private bool withoutLadder = true;
    [SerializeField] private bool withLadder = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (withoutLadder == true)
        //{
        //    //play dialogue without ladder
        //    FindObjectOfType<CatLadyDT>().state = CatLadyDT.DialogueState.woLadder;
        //}


        if (hasLadder == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Oh wow, I got a ladder!");
            withLadder = true;
            Destroy(ladder);
        }


        //if (withLadder == true)
        //{
        //    //play dialogue with ladder
        //    FindObjectOfType<CatLadyDT>().state = CatLadyDT.DialogueState.wLadder;
        //}

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            hasLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasLadder = false;
    }
}
