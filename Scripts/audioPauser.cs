using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPauser : MonoBehaviour
{
    public AudioSource jmanMusic;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            jmanMusic.Pause();
        }

    }

}
