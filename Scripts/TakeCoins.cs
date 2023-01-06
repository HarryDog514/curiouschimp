using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoins : MonoBehaviour
{
    public string TAG;
    public seedsScripts CoinsScript;

    //WARNiNG THIS TAKES ALL OF YOUR COINS!!!
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == TAG)
        {
            PlayerPrefs.SetInt("seeds", 0);
        }
    }
}
