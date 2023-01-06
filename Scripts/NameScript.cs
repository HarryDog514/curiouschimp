using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;
public class NameScript : MonoBehaviour
{
    public string NameVar;
    public TextMeshPro NameText;

    public void Start()
    {
        NameVar = PlayerPrefs.GetString("username");
    }

    private void Update()
    {
        if (NameVar.Length > 11)
        {
            NameVar = NameVar.Substring(0, 11);
        }
        NameText.text = NameVar;
        PhotonNetwork.LocalPlayer.NickName = NameVar;
        PlayerPrefs.SetString("username", NameVar);
    }
}
