using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("profile");
    }
    public void options()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void quit()
    {
        Application.Quit();
    }
}
