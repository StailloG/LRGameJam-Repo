using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInTree : DialogueTalk
{
    SpriteRenderer spriteRenderer; 
    Animator animator;
    [SerializeField] Sprite sprite; 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space) && !Textbox.On)
        {
            animator.enabled = false;
            spriteRenderer.sprite = sprite;
            
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
