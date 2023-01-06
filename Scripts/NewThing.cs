using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class NewThing : MonoBehaviour
{
    [SerializeField]
    public GameObject jumpidiot;
    public GameObject PBBV;
    public GameObject player;
    public AudioSource scream;
    public GameObject Map;
    public GameObject Sky;

    void Start()
    {
        jumpidiot.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(Scare());
    }
    IEnumerator Scare()
    {
        jumpidiot.SetActive(true);
        Map.SetActive(false);
        Sky.SetActive(true);
        jumpidiot.gameObject.GetComponent<Animator>().enabled = true;
        jumpidiot.gameObject.GetComponent<Animator>().Play("oooooo");
        scream.Play();
        yield return new WaitForSeconds(1f);
        jumpidiot.gameObject.GetComponent<Animator>().enabled = false;
        jumpidiot.SetActive(false);
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
        SceneManager.LoadScene(0);
    }
}