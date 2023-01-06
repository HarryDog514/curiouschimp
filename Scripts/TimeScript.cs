using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public int SysTimeH;
    public int RightTimeH;
    public int RightTimeM;
    public string FullTime;

    // Start is called before the first frame update
    void Update()
    {
        SysTimeH = System.DateTime.Now.Hour;
        if (SysTimeH > 12)
        {
            RightTimeH = SysTimeH - 12;
        }
        else
        {
            RightTimeH = System.DateTime.Now.Hour;
        }

        RightTimeM = System.DateTime.Now.Minute;

        if (RightTimeM < 10)
        {
            FullTime = RightTimeH + ":" + "0" + RightTimeM;
        }
        else
        {
            FullTime = RightTimeH + ":" + RightTimeM;
        }
    }
}
