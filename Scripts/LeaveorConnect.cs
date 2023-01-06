using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LeaveorConnect : MonoBehaviourPunCallbacks
{
	public NetworkManager networkManager;
	public bool LeaveButton;


	private void OnTriggerEnter(Collider other)
	{
		if ((other.gameObject.name == "LeftHand Controller" || other.gameObject.name == "RightHand Controller"))
		{
			if (LeaveButton && PhotonNetwork.InRoom)
			{
				PhotonNetwork.LeaveRoom();
				PhotonNetwork.LeaveLobby();
			}
			else if (!LeaveButton && !PhotonNetwork.InRoom)
			{
				ConnectToServer();
			}
		}
	}

    void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("conning to the server my G...");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("connected to server!");
        base.OnConnectedToMaster();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;
        roomOptions.IsOpen = true;

        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a Room");
        base.OnJoinedRoom();
    }
}
