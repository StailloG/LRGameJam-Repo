using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public Rigidbody2D playerRB;
    public float speed = 6f;
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        //call player rigidbody
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;


        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        transform.position += movement * Time.deltaTime * speed;
    }



    public void EnableMovement()
    {
        canMove = true;
    }

    public void DisableMovement()
    {
        canMove= false;
    }
}
