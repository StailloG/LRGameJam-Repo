using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTalk : MonoBehaviour
{
    [SerializeField] private Dialogue_Set introDialogue;
    [SerializeField] private Dialogue_Set finalDialogue;
    [SerializeField][Range(1.0f, 10.0f)] private float radius;  
    public bool nearPlayer
    {
        get
        {

            return (
                (FindObjectOfType<PlayerMovement>() != null) &&
                (Mathf.Abs(Vector3.Distance(transform.position, GameObject.FindObjectOfType<PlayerMovement>().transform.position)) <= radius)
                );
        }
    }



    private void Update()
    {
        //if player presses talk button Talk
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space) && !Textbox.On)
        {
            Talk();
        }
    }

    public virtual void Talk()
    {
        IntroDialogue();
    }

    public void IntroDialogue()
    {
        introDialogue?.sendDialogue();
    }


    public void FinalDialogue()
    {
        finalDialogue?.sendDialogue();
    }


}
