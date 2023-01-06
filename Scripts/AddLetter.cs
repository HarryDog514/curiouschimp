using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLetter : MonoBehaviour
{
    public NameScript nameScript;
    public string Handtag;
    public string Letter;
    public AudioSource clicka;
    public Material Red;
    public Material White;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == Handtag) 
        {
            StartCoroutine(type());
        }
    }

    IEnumerator type()
    {
        base.GetComponent<Renderer>().material = Red;
        clicka.Play();
        nameScript.NameVar += Letter;
        yield return new WaitForSeconds(0.3f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == Handtag)
        {
            base.GetComponent<Renderer>().material = White;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == Handtag)
        {
            base.GetComponent<Renderer>().material = Red;
        }
    }
}