using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class pausemenu : MonoBehaviour
{
    private string s;
    private void Start()
    {
        s = SceneManager.GetActiveScene().name;
        
    }
    public GameObject pause;
    public data d = new data();
    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(s);
        
    }
    public void resume()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
    }
    public void main()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }
    
    [System.Serializable]
    public class data
    {
        public int level = 1;
        public int score = 0;

    }
    public void savetojson()
    {
        dataclass playerdata = new dataclass();
        playerdata.level = 1;
        playerdata.score = 0;
        string gamed = JsonUtility.ToJson(d, true);
        string path = Application.persistentDataPath + "/data.json";
        Debug.Log(path);
        
        File.WriteAllText(path, gamed);
    }
}
