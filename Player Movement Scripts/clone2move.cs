using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone2move : MonoBehaviour
{
    // Start is called before the first frame update
    private List<replay> input1;
    private SpriteRenderer renderer;
    private List<List<replay>> cloneinput = new List<List<replay>>();
    public LayerMask groundlayer;
    public playerscript sc;
    //private GameObject player = GameObject.Find("Square");
    bool isgrounded;
    public Transform groundcheck;
    int i = 0;
    Rigidbody2D rb;
    public float jumpforce = 5f;
    public int cloneidnew;
    private List<replay> temp = new List<replay>();
    void Start()
    {
        float a = Random.Range(0.5f, 1f);
        float b = Random.Range(0.5f, 1f);
        float c = Random.Range(0.4f, 1f);
        float d = Random.Range(0.3f, 1f);

        cloneinput = sc.clonereplay;
        //playerscript sc = GameObject.Find("Square").GetComponent<playerscript>();
        input1 = sc.InputRecord1;

        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        renderer.color = new Color(a, b, c, d);
        cloneidnew = sc.cloneid;
        cloneinput = sc.clonereplay;

        List<replay> temp = cloneinput[cloneidnew - 1];
        Debug.Log(temp.Count + " k" + temp.Count);
    }

    // Update is called once per frame
    void Update()


    {

        isgrounded = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, groundlayer);
        if (Time.time > 1)
        {
            replay temp = input1[i];
            transform.position = new Vector2(transform.position.x + temp.x * Time.deltaTime * 10f, transform.position.y);
            if (temp.y == 1 && isgrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            }
            i++;

        }
        /*if (i < temp.Count)
        {
            replay temp1 = temp[i];
            transform.position = new Vector2(transform.position.x + temp1.x * Time.deltaTime * 10f, transform.position.y);
            i++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            
           
            
            

        }*/


    }
}
