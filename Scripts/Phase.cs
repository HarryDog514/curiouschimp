using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Phase : MonoBehaviour
{
    [SerializeField]
    public GameObject jumpidiot;
    public GameObject PBBV;
    public GameObject player;
    public AudioSource scream;
    public GameObject Map;
    public GameObject Sky;
    public Transform location;

    void Start()
    {
        jumpidiot.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(Scare2());
    }
    IEnumerator Scare2()
    {
        jumpidiot.SetActive(true);
        Map.SetActive(false);
        Sky.SetActive(true);
        scream.Play();
        yield return new WaitForSeconds(1f);
        jumpidiot.gameObject.GetComponent<Animator>().enabled = false;
        jumpidiot.SetActive(false);
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
