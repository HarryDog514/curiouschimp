using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class Bombkill : MonoBehaviourPunCallbacks
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.LeaveLobby();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
