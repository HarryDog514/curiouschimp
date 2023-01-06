using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Checkstatus : MonoBehaviour
{
    public GameObject thing;
    public Material red;
    public Material Green;
    public TextMeshPro Text;
    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.InRoom)
        {
            thing.GetComponent<Renderer>().material = Green;
            Text.text = "Connected";
        }
        else
        {
            thing.GetComponent<Renderer>().material = red;
            Text.text = "Disconnected";
        }
    }
}
