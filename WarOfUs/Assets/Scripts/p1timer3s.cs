using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p1timer3s : MonoBehaviour
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
        SceneManager.LoadScene(22);
        Destroy(allfunctions.gameObject);
    }
}
