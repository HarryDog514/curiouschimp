using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class SceneSwitch : MonoBehaviourPunCallbacks
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.LeaveLobby();
            SceneManager.LoadScene(sceneName);
        }
    }
}
