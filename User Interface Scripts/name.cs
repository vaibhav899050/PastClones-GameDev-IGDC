using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class name : MonoBehaviour
{
    public TMP_Text t;
    public int num;
    public string name1;
    public string name2;
    public string name3;
    public int b;
    // Start is called before the first frame update
    void Start()
    {
        //string gamed = JsonUtility.ToJson(d);
        string path = File.ReadAllText(Application.persistentDataPath + "/player.json");
        numplayer playerdata = JsonUtility.FromJson<numplayer>(path);
        //System.IO.File.WriteAllText(path, gamed);
        //string gamed = System.IO.File.ReadAllText(path);
        name1 = playerdata.name1;
        name2 = playerdata.name2;
        name3 = playerdata.name3;
        num = playerdata.num;
        string path1 = File.ReadAllText(Application.persistentDataPath + "/playernum.json");
        select playerdata1 = JsonUtility.FromJson<select>(path1);
        b = playerdata1.num;
        if (b == 1)
        {
            t.text = name1;
        }
        if (b == 2)
        {
            t.text = name2;
        }
        if (b == 3)
        {
            t.text = name3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
