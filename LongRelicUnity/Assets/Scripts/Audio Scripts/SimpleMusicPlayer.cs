using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource music;
    void Start()
    {
        music = GetComponent<AudioSource>(); 
        music.Play();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

   
}
