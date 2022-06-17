using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject ladder;

    [Header("Bools")]
    [SerializeField] private bool hasLadder = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasLadder == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Oh wow, I got a ladder!");
            Destroy(ladder);
        }
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
