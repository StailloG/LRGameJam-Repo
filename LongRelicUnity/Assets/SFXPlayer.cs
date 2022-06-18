using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip catClip; 
    [SerializeField] AudioClip trashClip;
    [SerializeField] AudioClip coinClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayCat()  
    {

        //randomizer 
        RandomizeSFX();
        audioSource.PlayOneShot(catClip);
    }
    public void PlayTrash()
    {
        RandomizeSFX();
        //randomizer 
        audioSource.PlayOneShot(trashClip);
    }

    public void PlayCoin()
    {
        RandomizeSFX();
        //randomizer 
        audioSource.PlayOneShot(coinClip);
    }

    void RandomizeSFX()
    {
        audioSource.volume = Random.Range(0.95f, 1.05f);
        audioSource.pitch = Random.Range(0.95f, 1.05f);
    }
}
