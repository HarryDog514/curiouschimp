using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followlayer : MonoBehaviour
{
    public Transform Head;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Head.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Head.transform.position;
    }
}
