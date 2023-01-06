using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerNameNetwork : MonoBehaviour
{
	public PhotonView photonView;

	public TextMeshPro nameTag;

	private void Start()
	{
		if (photonView.IsMine)
		{
			if (PlayerPrefs.HasKey("username"))
			{
				PhotonNetwork.NickName = PlayerPrefs.GetString("username");
			}
			else
			{
				PlayerPrefs.SetString("username", "chimp" + Random.Range(0, 9999));
				PhotonNetwork.NickName = PlayerPrefs.GetString("username");
			}
		}
		SetName();
	}

	private void SetName()
	{
		nameTag.text = photonView.Owner.NickName;
	}

	private void Update()
	{
		if (nameTag.text != photonView.Owner.NickName)
		{
			SetName();
		}
	}
}
