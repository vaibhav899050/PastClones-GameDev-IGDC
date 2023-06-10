using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
public class pdc : MonoBehaviour
{
    public int level = 0;
    public int score = 0;

    private void Start()
    {
        loadtojson();
    }


    
    public void loadtojson()
    {
        //string gamed = JsonUtility.ToJson(d);
        string path = File.ReadAllText(Application.persistentDataPath + "/data.json");
        dataclass playerdata = JsonUtility.FromJson<dataclass>(path);
        //System.IO.File.WriteAllText(path, gamed);
        //string gamed = System.IO.File.ReadAllText(path);
        level = playerdata.level;
        score = playerdata.score;
        Debug.Log(path);
    }



}
