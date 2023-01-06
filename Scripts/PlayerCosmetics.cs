using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerCosmetics : MonoBehaviour
{
	public List<GameObject> Cosmetics;

	[PunRPC]
	private void EnableCosmetic(string cosmeticName)
	{
		for (int i = 0; i < Cosmetics.Count; i++)
		{
			if (Cosmetics[i].name == cosmeticName)
			{
				Cosmetics[i].SetActive(true);
			}
		}
	}

	[PunRPC]
	private void DisableCosmetic(string cosmeticName)
	{
		for (int i = 0; i < Cosmetics.Count; i++)
		{
			if (Cosmetics[i].name == cosmeticName)
			{
				Cosmetics[i].SetActive(false);
			}
		}
	}
}
