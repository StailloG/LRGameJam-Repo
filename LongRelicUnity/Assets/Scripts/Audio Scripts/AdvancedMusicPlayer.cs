using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedMusicPlayer : MonoBehaviour
{
    public AudioSource stem1;
    public AudioSource stem2;
    public AudioSource stem3;
    public AudioSource stem4;
   
    public float dur = 3.333f;

    // Start is called before the first frame update
    void Start()
    {
        //play all music but mute them all immiediately 
        //NO STOPPING ONLY MUTING AND UNMUTING 
        PlayAllSources();
        StartCoroutine(StartFade(stem1, dur, 1.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        return;
        if(Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(StartFade(stem2, dur, 1.0f, 0.0f));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(StartFade(stem3, dur, 1.0f, 0.0f));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(StartFade(stem4, dur, 1.0f, 0.0f));
        }
    }
    void PlayAllSources()
    {
        stem1.Play();
        stem2.Play();
        stem3.Play();
        stem4.Play();
      
        stem1.mute = true;
        stem2.mute = true;
        stem3.mute = true;
        stem4.mute = true;
       
    }


    public IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume, float startVolume)
    {
        Debug.Log(audioSource.gameObject.name);
        if(audioSource.mute == true)
            audioSource.mute = false;

        float currentTime = 0;
        //float start = audioSource.volume;
        audioSource.volume = startVolume; 

        while (currentTime < duration)
        {
           
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

}
