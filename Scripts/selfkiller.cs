using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class selfkiller : MonoBehaviour
{
    public GameObject boomboom;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Die());
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(2f);
        PhotonNetwork.Destroy(boomboom);
    }
}
