using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class playerselect : MonoBehaviour
{
    public void select()
    {
        select playerdata = new select();
        playerdata.num = 1;
        
        //j3.text = namem.text;
        string gamed = JsonUtility.ToJson(playerdata, true);
        string path = Application.persistentDataPath + "/playernum.json";
        //n3.SetActive(true);
        Debug.Log(path);

        File.WriteAllText(path, gamed);
        SceneManager.LoadScene("levelselector");
    }
    public void select1()
    {
        select playerdata = new select();
        playerdata.num = 2;

        //j3.text = namem.text;
        string gamed = JsonUtility.ToJson(playerdata, true);
        string path = Application.persistentDataPath + "/playernum.json";
        //n3.SetActive(true);
        Debug.Log(path);


        File.WriteAllText(path, gamed);
        SceneManager.LoadScene("levelselector");
    }
    public void select2()
    {
        select playerdata = new select();
        playerdata.num = 3;

        //j3.text = namem.text;
        string gamed = JsonUtility.ToJson(playerdata, true);
        string path = Application.persistentDataPath + "/playernum.json";
        //n3.SetActive(true);
        Debug.Log(path);

        File.WriteAllText(path, gamed);
        SceneManager.LoadScene("levelselector");
    }
}
