using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagement : MonoBehaviour
{
    //variables
    public int coinCounter;
    public Text counterTxt;
    public Coins[] coinList;

    // Start is called before the first frame update
    void Start()
    {
        counterTxt.gameObject.SetActive(false);

        coinList = FindObjectsOfType<Coins>(); //array of all coins in the scene
        
        for(int i = 0; i <= coinList.Length; i++)
        {
            coinList[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //setactive(true) after speaks with store keeper
    }

    public void addCoin()
    {
        coinCounter++;
        counterTxt.text = "Coins Obtained:  " + coinCounter;
    }

    public void openCoins()
    {
        for (int i = 0; i < coinList.Length; i++)
        {
            coinList[i].gameObject.SetActive(true);
        }
    }

    public IEnumerator coinsObtainedAppear()
    {
        yield return new WaitForSeconds(15f);

        counterTxt.gameObject.SetActive(true);
        counterTxt.text = "Coins Obtained:  " + coinCounter;
    }
}
