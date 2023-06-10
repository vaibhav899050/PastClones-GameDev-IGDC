using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timecount : MonoBehaviour
{
    public TMP_Text text;
    public float period = 1f;
    private float nextActionTime = 0.0f;
    //public GameObject tt;
    public Transform groundcheck;
    public LayerMask flag;
    public float starttime;
    bool iswon;

    int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = text.GetComponent<TMP_Text>();
        text.text = "0";
        //nextActionTime = 0-Time.time;
        starttime = Time.time;
        
        //t = 0;

    }

    // Update is called once per frame
    void Update()
    {
        iswon = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, flag);
        float t = Time.time - starttime;
        if (t > nextActionTime && !iswon)
        {
            nextActionTime += period;
            t += 1;
                
                //i++;

        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            tt.SetActive(false);
            Time.timeScale = 1f;
            nextActionTime = 0;
        }*/
        text.text = t.ToString();
    }
}
