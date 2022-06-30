using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coins = 0;
    public TMP_Text coinsText;
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Coin"){
            coins++;
            coinsText.text = coins.ToString();
        }
    }
}
