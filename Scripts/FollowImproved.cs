using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowImproved : MonoBehaviour
{

    public Transform Sphere;
    public Transform Controller;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Sphere.transform.position;
        transform.rotation = Controller.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Sphere.transform.position;
        transform.rotation = Controller.transform.rotation;
    }
}
