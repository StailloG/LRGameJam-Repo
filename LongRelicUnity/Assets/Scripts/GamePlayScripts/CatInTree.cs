using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInTree : DialogueTalk
{
    SpriteRenderer spriteRenderer; 
    Animator animator;
    [SerializeField] Sprite sprite;
    [SerializeField] GameObject ladderGO; 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        ladderGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space) && !Textbox.On)
        {
            var catLady = FindObjectOfType<CatLadyDT>();
            if (catLady.state == CatLadyDT.DialogueState.wLadder)
            {
                animator.enabled = false;
                spriteRenderer.sprite = sprite;
                ladderGO.SetActive(true);

                catLady.state = CatLadyDT.DialogueState.saveCat;
            }
        }
    }

    private void OnMouseDown()
    {
      

    }
}
