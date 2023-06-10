using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void level1()
    {
        //Time.timeScale = 0f;
        SceneManager.LoadScene("level01");
    }
    public void level2()
    {
        SceneManager.LoadScene("level02");
    }
    public void level3()
    {
        SceneManager.LoadScene("level03");
    }
    public void level4()
    {
        SceneManager.LoadScene("level04");
    }
    public void level5()
    {
        SceneManager.LoadScene("level05");
    }
    public void level6()
    {
        SceneManager.LoadScene("level06");
    }
    public void level7()
    {
        SceneManager.LoadScene("level07");
    }
    public void level8()
    {
        SceneManager.LoadScene("level08");
    }
}

