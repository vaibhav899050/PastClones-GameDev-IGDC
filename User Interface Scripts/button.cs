using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class button : MonoBehaviour
{
    public TMP_InputField namem;
    public int num;
    public string name1;
    public string name2;
    public string name3;
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public TMP_Text j1;
    public TMP_Text j2;
    public TMP_Text j3;

    void Start()
    {
        loadtojson();
    }
    public void add()
    {
        if (num == 0)
        {
            numplayer playerdata = new numplayer();
            playerdata.num = 1;
            playerdata.name1 = namem.text;
            playerdata.name2 = "";
            playerdata.name3 = "";
            string gamed = JsonUtility.ToJson(playerdata, true);
            string path = Application.persistentDataPath + "/player.json";
            j1.text = namem.text;
            Debug.Log(path);
            n1.SetActive(true);

            File.WriteAllText(path, gamed);
        }
        if (num == 1)
        {
            numplayer playerdata = new numplayer();
            playerdata.num = 2;
            playerdata.name1 = name1;
            playerdata.name2 = namem.text;
            j2.text = namem.text;
            n2.SetActive(true);
            playerdata.name3 = "";
            string gamed = JsonUtility.ToJson(playerdata, true);
            string path = Application.persistentDataPath + "/player.json";
            Debug.Log(path);

            File.WriteAllText(path, gamed);
        }
        if (num == 2)
        {
            numplayer playerdata = new numplayer();
            playerdata.num = 3;
            playerdata.name1 = name1;
            playerdata.name2 = name2;
            playerdata.name3 = namem.text;
            j3.text = namem.text;
            string gamed = JsonUtility.ToJson(playerdata, true);
            string path = Application.persistentDataPath + "/player.json";
            n3.SetActive(true);
            Debug.Log(path);

            File.WriteAllText(path, gamed);
        }
        
    }
    public void loadtojson()
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
        if (num == 1)
        {
            n1.SetActive(true);
        }
        if (num == 2)
        {
            n1.SetActive(true);
            n2.SetActive(true);
        }
        if (num == 3)
        {
            n1.SetActive(true);
            n2.SetActive(true);
            n3.SetActive(true);
        }
        j1.text = name1;
        j2.text = name2;
        j3.text = name3;
        Debug.Log(path);
    }
    // Start is called before the first frame update
    

    
}
