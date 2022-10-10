using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class retry : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }
    public void ExitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
