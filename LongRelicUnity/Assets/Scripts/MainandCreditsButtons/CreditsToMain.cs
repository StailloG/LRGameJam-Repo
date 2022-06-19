using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsToMain : MonoBehaviour
{
    public void ToMainMenu()
    {
        var music = FindObjectOfType<AdvancedMusicPlayer>();
        if(music.gameObject != null)
        Destroy(music.gameObject);
        SceneManager.LoadScene(0);
    }
}
