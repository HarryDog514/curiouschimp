using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScriptRead : MonoBehaviour
{
    public TimeScript timeScript;
    public TextMeshProUGUI time;

    // Update is called once per frame
    void Update()
    {
        time.text = timeScript.FullTime;
    }
}
