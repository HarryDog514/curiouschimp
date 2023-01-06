using System.Collections;
using Photon.Pun;
using UnityEngine;
using UnityEngine.XR;

public class CosmeticsController : MonoBehaviour
{
	public bool enableButton;

	public string CosmeticName;

	private float hapticWaitSeconds = 0.05f;

	private NetworkPlayerSpawner networkPManager;

	private PhotonView photonView;

	private void Start()
	{
		networkPManager = GameObject.Find("Network Manager").GetComponent<NetworkPlayerSpawner>();
	}

	private void Update()
	{
		if (PhotonNetwork.InRoom)
		{
			photonView = networkPManager.spawnedPlayerPrefab.GetComponent<PhotonView>();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (PhotonNetwork.InRoom && (other.gameObject.name == "LeftHand Controller" || other.gameObject.name == "RightHand Controller"))
		{
			if (enableButton)
			{
				photonView.RPC("EnableCosmetic", RpcTarget.AllBuffered, CosmeticName);
			}
			else
			{
				photonView.RPC("DisableCosmetic", RpcTarget.AllBuffered, CosmeticName);
			}
			if (other.gameObject.name == "LeftHand Controller")
			{
				StartVibration(true, 0.7f, 0.15f);
			}
			if (other.gameObject.name == "RightHand Controller")
			{
				StartVibration(false, 0.7f, 0.15f);
			}
		}
	}


	public void StartVibration(bool forLeftController, float amplitude, float duration)
	{
		StartCoroutine(HapticPulses(forLeftController, amplitude, duration));
	}

	private IEnumerator HapticPulses(bool forLeftController, float amplitude, float duration)
	{
		float startTime = Time.time;
		uint channel = 0u;
		InputDevice device = ((!forLeftController) ? InputDevices.GetDeviceAtXRNode(XRNode.RightHand) : InputDevices.GetDeviceAtXRNode(XRNode.LeftHand));
		while (Time.time < startTime + duration)
		{
			device.SendHapticImpulse(channel, amplitude, hapticWaitSeconds);
			yield return new WaitForSeconds(hapticWaitSeconds * 0.9f);
		}
	}
}
