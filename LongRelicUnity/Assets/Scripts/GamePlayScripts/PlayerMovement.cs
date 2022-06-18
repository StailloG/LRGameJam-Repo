using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public Rigidbody2D playerRB;
    public float speed = 6f;
    private bool canMove = true;

    private float moveH;
    private float moveV;
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
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");

       Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0f);
      
       //using rb & velocity to stop jittering between gameobjects
        playerRB.velocity = movement;
       
    }

    private void FixedUpdate()
    {
       
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
