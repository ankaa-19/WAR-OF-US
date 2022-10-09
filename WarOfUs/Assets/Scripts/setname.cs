using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setname : MonoBehaviour
{
    public GameObject setnameobj;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;

    public void savenamebutton()
    {
        PlayerPrefs.SetString("p1sn", inputfield1.text);
        PlayerPrefs.SetString("p2sn", inputfield2.text);
    }
}
