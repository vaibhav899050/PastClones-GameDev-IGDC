using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutt : MonoBehaviour
{

    public void main()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }
    
}
