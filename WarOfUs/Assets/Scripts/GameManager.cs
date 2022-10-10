using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    public float special1 = 0f;
    public float special2 = 0f;
    public float p1max;
    public float p2max;
    public int rand;


    private void Start()
    {  
        p1health = PlayerPrefs.GetFloat("p1hp");
        p2health = PlayerPrefs.GetFloat("p2hp");
        p1max = PlayerPrefs.GetFloat("p1m");
        p2max = PlayerPrefs.GetFloat("p2m");
        special1 = PlayerPrefs.GetFloat("spn1");
        special2 = PlayerPrefs.GetFloat("spn2");
        healthcheck();
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("p1hn", p1health);
        PlayerPrefs.SetFloat("p2hn", p2health);
        PlayerPrefs.SetFloat("p1max", p1max);
        PlayerPrefs.SetFloat("p2max", p2max);
        PlayerPrefs.SetFloat("sp1", special1);
        PlayerPrefs.SetFloat("sp2", special2);
    }


    public void healthcheck()
    {
        if (p1health < 1f)
        {
            SceneManager.LoadScene(24);
        }
        if (p2health < 1f)
        {
            SceneManager.LoadScene(23);
        }

    }

    public void p1hp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 55)
        {
            SceneManager.LoadScene(3);
            p2health -= 8f;
        }
        else
        {
            SceneManager.LoadScene(15);
        }
    }

    public void p1hk()
    {
        rand = Random.Range(0,100);   
        if (rand <= 45)
        {
            SceneManager.LoadScene(4);
            p2health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(13);
        }
    }

    public void p1lp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 75)
        {
            SceneManager.LoadScene(5);
            p2health -= 3f;
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
            p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(14);
        }
    }

    public void p1s()
    {
        if(special1 >=1 )
        {
        
        }
        else
        {
        if(p1health <=30)
        {
        SceneManager.LoadScene(7);
        p2health -= 25f;
        special1 += 1f;
        }
        }

    }

    public void p2hp()
    {
        rand = Random.Range(0,100);   
        if (rand <= 55)
        {
            SceneManager.LoadScene(8);
            p1health -= 6f;
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
            p1health -= 12f;
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
            p1health -= 3f;
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
            p1health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(18);
        }
    }

    public void p2s()
    {
        if(special2 >= 1)
        {
        
        }
        else
        {
        if (p2health <= 30)
        {
        SceneManager.LoadScene(12);
        p1health -= 25f;
        special2 += 1f;
        }
        }
    }
}
