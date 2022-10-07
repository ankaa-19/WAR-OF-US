using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    public float p2max;
    public float p1max;
    public float gametime = 60f;
    public int rand;
    public Image Healthbar1;
    public Image Healthbar2;
    public GameObject allfunctions;


    private void Start()
    {  
        p1max = p1health;
        p2max = p2health; 
        DontDestroyOnLoad(allfunctions.gameObject);
    }

    private void Update()
    {
        Healthbar1.fillAmount = p1health / p1max;
        Healthbar2.fillAmount = p2health / p2max;

    }

    private void FixedUpdate()
    {
        gametime -= Time.deltaTime;
    }

    IEnumerator delayedchangescene()
    {
        yield return new WaitForSeconds(5f);
    }

    public void p1hp()
    {
        SceneManager.LoadScene(3);
    }

    public void p1hk()
    {
        SceneManager.LoadScene(4);
    }

    public void p1lp()
    {
        SceneManager.LoadScene(5);
    }

    public void p1lk()
    {
        SceneManager.LoadScene(6);
    }

    public void p1s()
    {
        SceneManager.LoadScene(7);
    }


    public void p2hp()
    {
        SceneManager.LoadScene(8);
    }

    public void p2hk()
    {
        SceneManager.LoadScene(9);
    }

    public void p2lp()
    {
        SceneManager.LoadScene(10);
    }

    public void p2lk()
    {
        SceneManager.LoadScene(11);
    }

    public void p2s()
    {
        SceneManager.LoadScene(12);
    }
}
