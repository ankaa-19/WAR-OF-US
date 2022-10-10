using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorytimer : MonoBehaviour
{

    public GameObject victimer;

    void Start()
    {
        StartCoroutine(victortimer());
    }

    IEnumerator victortimer()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(21);
        Destroy(victimer.gameObject);
    }


}
