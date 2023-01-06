using UnityEngine;

public class swimtrigger : MonoBehaviour
{
	public Swimmy swimmy;

	public Rigidbody player;

	public AudioSource water;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			swimmy.enabled = true;
			player.useGravity = false;
			water.enabled = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			swimmy.enabled = false;
			player.useGravity = true;
			water.enabled = false;
		}
	}
}
