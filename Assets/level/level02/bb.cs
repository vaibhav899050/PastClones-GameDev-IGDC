using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bb : MonoBehaviour
{
    public void main()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }
    public void next()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level03");
    }
}
