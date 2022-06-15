using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagement : MonoBehaviour
{
    //variables
    public int coinCounter;
    public Text counterTxt;

    // Start is called before the first frame update
    void Start()
    {
        counterTxt.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //setactive(true) after speaks with store keeper
    }

    public void addCoin()
    {
        coinCounter++;
        counterTxt.gameObject.SetActive(true);
        counterTxt.text = "Coins Obtained:  " + coinCounter;
    }
}
