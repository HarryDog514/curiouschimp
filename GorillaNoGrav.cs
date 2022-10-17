using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorillaNoGrav : MonoBehaviour
{
    [SerializeField] public Rigidbody Rigid;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        Rigid.useGravity = false; // This is if you want to turn the gravity off;
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        Rigid.useGravity = true; // This is if you want the gravity to be turned back on;
    }

}
