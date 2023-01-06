using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedsDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public seedsScripts seeds;
    public TextMeshProUGUI text;
    public string name = "seeds";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "You have " + seeds.seeds + " " + name;
    }
}