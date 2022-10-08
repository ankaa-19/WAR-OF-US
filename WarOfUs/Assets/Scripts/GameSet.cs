using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;

    public void saveButtonName()
    {
    PlayerPrefs.SetString("P1Name", inputField1.text);
    PlayerPrefs.SetString("P2Name", inputField2.text);
    }
    public void SetHP50(){
        
        PlayerPrefs.SetFloat("p1h", 50);
        PlayerPrefs.SetFloat("P2h", 50);
    }
    public void SetHP100(){
        
        PlayerPrefs.SetFloat("P1h", 100);
        PlayerPrefs.SetFloat("P2h", 100);
    }
    public void SetHP150(){
        
        PlayerPrefs.SetFloat("P1h", 150);
        PlayerPrefs.SetFloat("P2h", 150);
        
    }
}
