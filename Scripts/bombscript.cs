using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class bombscript : MonoBehaviour
{
    public GameObject thisbomb;
    public string PrefabName;
    public AudioSource Countdown;

    // set this on activate
    public void BombActivate()
    {
        StartCoroutine(Boom());
    }

    IEnumerator Boom()
    {
        Countdown.enabled = true;
        Countdown.Play();
        yield return new WaitForSeconds(30f);
        PhotonNetwork.Instantiate(PrefabName, thisbomb.transform.position, thisbomb.transform.rotation);
    }
}
