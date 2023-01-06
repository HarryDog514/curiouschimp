using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackspaceScript : MonoBehaviour
{
    public NameScript NameScript;
    public string HandTag;
    public AudioSource click;
    public Material White;
    public Material Red;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == HandTag)
        {
            StartCoroutine(Remove());
        }
    }

    IEnumerator Remove()
    {
        click.Play();
        NameScript.NameVar = NameScript.NameVar.Remove(NameScript.NameVar.Length - 1);
        yield return new WaitForSeconds(0.3f);
    }
}
