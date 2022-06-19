using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBlocks : MonoBehaviour
{
    public GameObject[] blocks;

    // Start is called before the first frame update
    void Start()
    {
        //1st gameojbect is active, rest is inactive
        for(int i = 1; i < blocks.Length; i++)
        {
            blocks[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if 1st block active
        if(blocks[0].activeInHierarchy)
        {
            StartCoroutine(Time());
        }
    }

    public IEnumerator Time()
    {
        yield return new WaitForSeconds(2f);

        for (int i = 1; i < blocks.Length; i++)
        {
            blocks[i].SetActive(true);
            yield return new WaitForSeconds(2f);
        }
    }
}
