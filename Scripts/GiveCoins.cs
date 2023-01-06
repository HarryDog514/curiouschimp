using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GiveCoins : MonoBehaviour
{
    public int AmountToGive;
    public seedsScripts CoinsScript;
    public string TAG;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == TAG)
        {
            PlayerPrefs.SetInt("seeds", PlayerPrefs.GetInt("seeds") + AmountToGive);
            print("Currency = " + CoinsScript.seeds);
            PlayerPrefs.SetInt("seed", 1);
        }
    }
}
