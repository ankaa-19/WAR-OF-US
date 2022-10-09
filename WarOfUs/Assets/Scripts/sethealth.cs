using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sethealth : MonoBehaviour
{
    public void sethp100()
    {
        PlayerPrefs.SetFloat("p1hp", 100f);
        PlayerPrefs.SetFloat("p2hp", 100f);
        PlayerPrefs.SetFloat("p1m", 100f);
        PlayerPrefs.SetFloat("p2m", 100f);
        Debug.Log("set to 100");
    }

    public void sethp50()
    {
        PlayerPrefs.SetFloat("p1hp", 50f);
        PlayerPrefs.SetFloat("p2hp", 50f);
        PlayerPrefs.SetFloat("p1m", 50f);
        PlayerPrefs.SetFloat("p2m", 50f);
        Debug.Log("set to 100");
    }
}