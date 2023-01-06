using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enable;
    public GameObject disable;
    public GameObject stand;
    public string CosmeticName;
    public int price;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "LeftHand Controller" || other.gameObject.name == "RightHand Controller")
        {
            if (PlayerPrefs.GetInt("seeds") >= price)
            {
                if (PlayerPrefs.GetInt(CosmeticName) != 1)
                {
                    int s = PlayerPrefs.GetInt("seeds");
                    PlayerPrefs.SetInt(CosmeticName, 1);
                    s -= price;
                    PlayerPrefs.SetInt("seeds", s);
                }
                if (PlayerPrefs.GetInt(CosmeticName) == 1)
                {
                    enable.SetActive(true);
                    disable.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
        }
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt(CosmeticName) == 1)
        {
            enable.SetActive(true);
            disable.SetActive(true);
            gameObject.SetActive(false);
            stand.SetActive(true);
        }
    }
}