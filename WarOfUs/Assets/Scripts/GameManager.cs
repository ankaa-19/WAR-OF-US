using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    public float p1max;
    public float p2max;
    public float gametime = 60f;
    public int rand;
    public Image Healthbar1;
    public Image Healthbar2;
    public GameObject allfunctions;


    private void Awake()
    {
        p1health = PlayerPrefs.GetFloat("p1h");
        p2health = PlayerPrefs.GetFloat("p2h");
        
    }

    private void Start()
    {  
        p1max = p1health;
        p2max = p2health; 
    }

    private void Update()
    {
        Healthbar1.fillAmount = p1health / p1max;
        Healthbar2.fillAmount = p2health / p2max;
    }

    public void p1hp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 55)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(15);
        }
        if (p1health <= 0){ 
            SceneManager.LoadScene(25);   
        }
    }

    public void p1hk()
    {
        rand = Random.Range(0,100);   
        if (rand <= 45)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
        SceneManager.LoadScene(17);
        }
    }

    public void p1lp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 75)
        {
            SceneManager.LoadScene(5);
        }
        else
        {
        SceneManager.LoadScene(16);
        }
    }

    public void p1lk()
    {
        rand = Random.Range(0,100);   
        if (rand <= 65)
        {
            SceneManager.LoadScene(6);
        }
        else
        {
        SceneManager.LoadScene(14);
        }
    }

    public void p1s()
    {
        SceneManager.LoadScene(7);
    }

    public void p2hp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 55)
        {
            SceneManager.LoadScene(8);
        }
        else
        {
        SceneManager.LoadScene(19);
        }
    }

    public void p2hk()
    {
        rand = Random.Range(0,100);   
        if (rand <= 45)
        {
            SceneManager.LoadScene(9);
        }
        else
        {
        SceneManager.LoadScene(17);
        }
    }

    public void p2lp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 75)
        {
            SceneManager.LoadScene(10);
        }
        else
        {
        SceneManager.LoadScene(20);
        }
    }

    public void p2lk()
    {
        rand = Random.Range(0,100);   
        if (rand <= 65)
        {
            SceneManager.LoadScene(11);
        }
        else
        {
        SceneManager.LoadScene(18);
        }
    }

    public void p2s()
    {
        SceneManager.LoadScene(12);
    }
}
