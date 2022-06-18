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
        
        for(int i = 0; i < coinList.Length; i++)
        {
            coinList[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if(FindObjectOfType<ShopKeeperDT>().hasKeyboard == true)
        {
            counterTxt.gameObject.SetActive(false);
        }
    }

    public void addCoin()
    {
        coinCounter++;
        counterTxt.text = "Coins Obtained:  " + coinCounter;

        if(coinCounter == 5)
        {
            FindObjectOfType<ShopKeeperDT>().state = ShopKeeperDT.DialogueState.transactioning;
        }
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
        yield return new WaitForSeconds(13f);

        counterTxt.gameObject.SetActive(true);
        counterTxt.text = "Coins Obtained:  " + coinCounter;
    }
}
