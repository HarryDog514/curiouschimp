using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class SceneSwitch1 : MonoBehaviourPunCallbacks
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Camera Offset" || other.gameObject.name == "Main Camera")
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.LeaveLobby();
            SceneManager.LoadScene(sceneName);
        }
    }
}
