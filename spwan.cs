using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject source;
    public GameObject cloneprefab;
    public float delay = 0.01f;
    public float timeer = 3f;
    private float nextActionTime = 0.0f;
    public float period = 10f;
    public Vector2 spawnpoint1;
    int i = 0;
    bool starttime;
    public GameObject currentclone;
    CapsuleCollider2D capsule;
    CapsuleCollider2D capsule1;
    

    float timer;
    public int cloneid1 = 0;
    void Start()
    {
        //spawnpoint1 = new Vector2(-0.05f, -0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (i <=3 && Input.GetKeyDown(KeyCode.K))
        {
            //timer += Time.deltaTime;
            //starttime = true;
            //starttime = false;
            i++;
            spwanobj();
            
            cloneid1 = i;
            
            timer = 0;




            /*if (Time.time > nextActionTime)
            {

                nextActionTime += period;
                spwanobj();
                i++;
                cloneid1 = i;
                //i++;

            }*/





        }
        if (starttime)
        {
            timer += Time.deltaTime;
        }
        if (timer > delay)
        {
            //nextActionTime += period;
            

        }



        //Debug.Log(i);


    }
    void spwanobj()
    {
        //Vector2 v = new Vector2(-6.78f, -3.5f);
        if (i == 1)
        {
            Vector2 v = new Vector2(-6.78f, -3.5f);
            Instantiate(cloneprefab, v, source.transform.rotation);
        }
        if (i == 2)
        {
            Vector2 v = new Vector2(-7.65f, -3.5f) ;
            Instantiate(cloneprefab, v, source.transform.rotation);
        }
        if (i == 3)
        {
            Vector2 v = new Vector2(-8.77f, -3.5f);
            Instantiate(cloneprefab, v, source.transform.rotation);
        }
        
    }
}
