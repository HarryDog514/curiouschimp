using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Roomname : MonoBehaviour
{
    public TextMeshPro Room;
    // I want to kill myself
    void Update()
    {
        if(PhotonNetwork.InRoom)
        {
            Room.text = PhotonNetwork.CurrentRoom.Name;
        }
        else
        {
            Room.text = "--NOT IN ROOM--";
        }
    }
}