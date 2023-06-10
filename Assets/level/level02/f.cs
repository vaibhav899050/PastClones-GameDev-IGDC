using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class f: MonoBehaviour


{
    public float speed = 10f;
    public TMP_Text t1;
    public TMP_Text t2;
    public GameObject player;
    public List<replay> InputRecord = new List<replay>();
    public List<replay> InputRecord1 = new List<replay>();
    public List<replay> InputRecord2 = new List<replay>();
    public List<List<replay>> clonereplay = new List<List<replay>>();
    public float jumpforce = 5f;
    Rigidbody2D rb;
    public GameObject clone1;
    public GameObject clone2;
    public GameObject clone3;
    public GameObject wonui;
    public Transform groundcheck;
    public LayerMask groundlayer;
    public LayerMask clonelayer;
    bool isgrounded;
    bool isgroundclone;
    int spacepress = 0;
    public int cloneid = 0;
    public int clonenum = 0;
    public spwan sc;
    public Vector2 spawnpoint;
    public Vector2 spawnpoint1;
    public Vector2 spawnpoint2;
    public Vector2 spawnpoint3;
    public Vector2 spawnpoint4;
    public int newcloneid;
    int i = 0;
    public float gravity = 10f;
    public GameObject pause;
    public AudioSource jump;
    public LayerMask flag;
    bool iswon;
    public float s1;
    public float s2;
    public float s3;
    public int num;
    public string n1;
    public string n2;
    public string n3;
    public float period = 1f;
    private float nextActionTime = 0.0f;
    public float starttime;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnpoint = new Vector2(-6.78f, -3.5f);
        //spawnpoint1 = new Vector2(-0.05f, -0.01f);
        spawnpoint2 = new Vector2(-7.65f, -3.51f);
        spawnpoint3 = new Vector2(-8.77f, -3.51f);
        spawnpoint4 = new Vector2(-9.72f, -3.51f);
        Time.timeScale = 1f;
        //newcloneid = sc.cloneid1;

        string path1 = File.ReadAllText(Application.persistentDataPath + "/playernum.json");
        select playerdata1 = JsonUtility.FromJson<select>(path1);

        num = playerdata1.num;
        string path2 = File.ReadAllText(Application.persistentDataPath + "/player.json");
        numplayer playerdata2 = JsonUtility.FromJson<numplayer>(path2);
        n1 = playerdata2.name1;
        n2 = playerdata2.name2;
        n3 = playerdata2.name3;
        starttime = Time.time;
        string path = File.ReadAllText(Application.persistentDataPath + "/level02score.json");
        levelscore playerdata = JsonUtility.FromJson<levelscore>(path);
        //System.IO.File.WriteAllText(path, gamed);
        //string gamed = System.IO.File.ReadAllText(path);

        s1 = playerdata.s1;
        s2 = playerdata.s2;
        s3 = playerdata.s3;




    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !iswon)
        {
            pause.SetActive(true);
            Time.timeScale = 0f;

        }
        if (i < 5 && Input.GetKeyDown(KeyCode.K))
        {

            //spwanobj();
            i++;
            newcloneid = i;
            if (i == 1)
            {
                player.transform.position = spawnpoint2;
            }
            if (i == 2)
            {
                player.transform.position = spawnpoint3;
            }
            if (i == 3)
            {
                player.transform.position = spawnpoint4;
            }
        }
        float t = Time.time - starttime;
        if (t > nextActionTime && !iswon)
        {
            nextActionTime += period;
            t += 1;

            //i++;

        }
        isgrounded = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, groundlayer);
        iswon = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, flag);
        isgroundclone = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, clonelayer);
        if (iswon)
        {

            if (num == 1)
            {
                //levelscore playerdata = new levelscore();
                levelscore playerdata = new levelscore();
                if (s1 != 0)
                {
                    if (t < s1)
                    {
                        s1 = t;
                    }

                }
                else
                {
                    s1 = t;
                }
                playerdata.s1 = s1;
                playerdata.s2 = s2;
                playerdata.s3 = s3;

                string gamed = JsonUtility.ToJson(playerdata, true);
                string path = Application.persistentDataPath + "/level02score.json";
                //n3.SetActive(true);
                Debug.Log(path);

                File.WriteAllText(path, gamed);
            }
            if (num == 2)
            {
                levelscore playerdata1 = new levelscore();
                if (s2 != 0)
                {
                    if (t < s2)
                    {
                        s2 = t;
                    }

                }
                else
                {
                    s2 = t;
                }
                playerdata1.s1 = s1;
                playerdata1.s2 = s2;
                playerdata1.s3 = s3;

                string gamed = JsonUtility.ToJson(playerdata1, true);
                string path = Application.persistentDataPath + "/level02score.json";
                //n3.SetActive(true);
                Debug.Log(path);

                File.WriteAllText(path, gamed);
            }
            if (num == 3)
            {

                levelscore playerdata2 = new levelscore();
                playerdata2.s1 = s1;
                playerdata2.s2 = s2;
                if (s3 != 0)
                {
                    if (t < s3)
                    {
                        s3 = t;
                    }

                }
                else
                {
                    s3 = t;
                }
                playerdata2.s3 = s3;

                string gamed = JsonUtility.ToJson(playerdata2, true);
                string path = Application.persistentDataPath + "/level02score.json";
                //n3.SetActive(true);
                Debug.Log(path);

                File.WriteAllText(path, gamed);

            }
            string path1 = File.ReadAllText(Application.persistentDataPath + "/level02score.json");
            levelscore player = JsonUtility.FromJson<levelscore>(path1);
            //System.IO.File.WriteAllText(path, gamed);
            //string gamed = System.IO.File.ReadAllText(path);

            s1 = player.s1;
            s2 = player.s2;
            s3 = player.s3;


            t2.text = s1 + "\n\n" + s2 + "\n\n" + s3;
            t1.text = n1 + "\n\n" + n2 + "\n\n" + n3;
            wonui.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        float horizontal = Input.GetAxisRaw("Horizontal");


        if (Input.GetKey(KeyCode.W))
        {

            spacepress = 1;
        }
        else
        {
            spacepress = 0;
        }

        //replay temp = new replay { x = horizontal , y = spacepress};

        //InputRecord.Add(temp);

        player.transform.position = new Vector3(player.transform.position.x + horizontal * speed * Time.fixedDeltaTime, player.transform.position.y);
        if (Input.GetKey(KeyCode.W))
        {
            if (isgroundclone || isgrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                jump.Play();
            }


        }
        if (newcloneid == 0)
        {
            replay temp = new replay { x = horizontal, y = spacepress };
            InputRecord.Add(temp);
        }
        else if (newcloneid == 1)
        {
            replay temp1 = new replay { x = horizontal, y = spacepress };
            InputRecord1.Add(temp1);
        }
        else if (newcloneid == 2)
        {
            replay temp2 = new replay { x = horizontal, y = spacepress };
            InputRecord2.Add(temp2);
        }
        /*if (Input.GetKeyDown(KeyCode.K))
        {
            clonenum += 1;
            player.transform.position = spawnpoint;

        }*/
        /*if (clone1.activeSelf != true)
        {
            replay temp1 = new replay { x = horizontal, y = spacepress };
            InputRecord.Add(temp1);
        }
        if (clone1.activeSelf == true && clone2.activeSelf != true)
        {
            replay temp2 = new replay { x = horizontal, y = spacepress };
            InputRecord1.Add(temp2);
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            if (clone1.activeSelf != true)
            {
                clone1.SetActive(true);
                clone1.transform.position = spawnpoint;
            }
            if(clone1.activeSelf==true && clone2.activeSelf != true)
            {
                clone2.SetActive(true);
                clone2.transform.position = spawnpoint;
            }
        }*/
        /*if (clonenum == 0)
        {
            replay temp1 = new replay { x = horizontal, y = spacepress };
            InputRecord.Add(temp1);
            if (Input.GetKeyDown(KeyCode.K))
            {
                clone1.SetActive(true);
                clone1.transform.position = spawnpoint;
                player.transform.position = spawnpoint;
                clonenum += 1;
            }
        }
        if (clonenum == 1)
        {
            replay temp2 = new replay { x = horizontal, y = spacepress };
            InputRecord1.Add(temp2);
            if (Input.GetKeyDown(KeyCode.K))
            {
                clone2.SetActive(true);
                clone2.transform.position = spawnpoint;
                clone1.transform.position = spawnpoint;
                player.transform.position = spawnpoint;
                clonenum += 1;
            }
        }
        if (clonenum == 2)
        {
            replay temp3 = new replay { x = horizontal, y = spacepress };
            InputRecord2.Add(temp3);
        }*/
        //Debug.Log(clonenum);
        /*if (Input.GetKeyDown(KeyCode.K))
        {
            cloneid += 1;
            Debug.Log(cloneid+" "+ InputRecord.Count);
            clonereplay.Add(InputRecord);
            Debug.Log("h" + clonereplay.Count);
            InputRecord.Clear();
        }*/



    }


}
