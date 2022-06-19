using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAndCredits : MonoBehaviour
{
    public void StartGame()
    {
        StartCoroutine(DelayPlay());
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

    public IEnumerator DelayPlay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
