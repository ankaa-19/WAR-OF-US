using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    public int rand;
    public float p2max;
    public float p1max;

    public void p1hp()
    {
        SceneManager.LoadScene(2);
    }

    public void p1hk()
    {
        SceneManager.LoadScene(3);
    }

    public void p1lp()
    {
        SceneManager.LoadScene(4);
    }

    public void p1lk()
    {
        SceneManager.LoadScene(5);
    }

    public void p1s()
    {
        SceneManager.LoadScene(6);
    }

    
    public void p2hp()
    {
        SceneManager.LoadScene(7);
    }

    public void p2hk()
    {
        SceneManager.LoadScene(8);
    }

    public void p2lp()
    {
        SceneManager.LoadScene(9);
    }

    public void p2lk()
    {
        SceneManager.LoadScene(10);
    }

    public void p2s()
    {
        SceneManager.LoadScene(11);
    }
}
