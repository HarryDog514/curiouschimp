using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabNetworkInteractable : XRGrabInteractable
{
	public PhotonView photonView;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnSelectEntered(SelectEnterEventArgs interactor)
	{
		photonView.RequestOwnership();
		base.OnSelectEntered(interactor);
	}
}
