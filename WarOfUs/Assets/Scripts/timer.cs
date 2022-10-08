using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{   
    public GameObject allfunctions;


    void Update()
    {
        StartCoroutine(delayedchangescene());
        DontDestroyOnLoad(allfunctions.gameObject);
        
    }

    IEnumerator delayedchangescene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(2);
        Destroy(allfunctions.gameObject);
    }
}
