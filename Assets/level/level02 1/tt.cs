using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt : MonoBehaviour
{
    // Start is called before the first frame update
    private List<replay> input1;
    private List<replay> input2;
    private List<replay> input3;
    private SpriteRenderer renderer;
    private List<List<replay>> cloneinput = new List<List<replay>>();
    public LayerMask groundlayer;
    public Animator animator;
    public t sc;
    public spwan sc1;
    public int clonenum;
    public Transform clonecheckobj;
    bool clonecheck;
    public LayerMask clone;
    //private GameObject player = GameObject.Find("Square");
    bool isgrounded;
    public Transform groundcheck;
    int i = 0;
    int j = 0;
    int k = 0;
    Rigidbody2D rb;
    public float jumpforce = 5f;
    //public Vector2 spwanpoint;
    public GameObject currentclone;
    CapsuleCollider2D capsule;
    CapsuleCollider2D capsule1;
    public int cloneidnew;
    private List<replay> temp = new List<replay>();
    void Start()
    {
        float a = Random.Range(0.5f, 1f);
        float b = Random.Range(0.5f, 1f);
        float c = Random.Range(0.4f, 1f);
        float d = Random.Range(0.3f, 1f);
        cloneidnew = sc1.cloneid1;
        cloneinput = sc.clonereplay;
        //playerscript sc = GameObject.Find("Square").GetComponent<playerscript>();
        input1 = sc.InputRecord;
        input2 = sc.InputRecord1;
        input3 = sc.InputRecord2;
        Debug.Log(cloneidnew);



        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        renderer.color = new Color(a, b, c, d);
        //cloneidnew = sc.cloneid;
        cloneinput = sc.clonereplay;

        List<replay> temp = cloneinput[cloneidnew - 1];
        Debug.Log(temp.Count + " k" + temp.Count);
    }

    private void Update()
    {

        //Physics2D.IgnoreCollision(capsule, capsule1);
        Vector2 spwanpoint = new Vector2(-6.78f, -3.5f);
        Vector2 spwanpoint1 = new Vector2(-7.65f, -3.5f);
        Vector2 spwanpoint2 = new Vector2(-8.77f, -3.5f);
        Vector2 spwanpoint3 = new Vector2(-9.72f, -3.5f);
        if (Input.GetKeyDown(KeyCode.K))
        {
            //transform.position = spwanpoint;
            if (cloneidnew == 1)
            {
                transform.position = spwanpoint;
            }
            if (cloneidnew == 2)
            {
                transform.position = spwanpoint1;
            }
            if (cloneidnew == 3)
            {
                transform.position = spwanpoint2;
            }
            i = 0;
            k = 0;
            j = 0;
        }
        isgrounded = Physics2D.OverlapCapsule(groundcheck.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, groundlayer);
        clonecheck = Physics2D.OverlapCapsule(clonecheckobj.position, new Vector2(0.99f, 0.16f), CapsuleDirection2D.Horizontal, 0, clone);

    }

    // Update is called once per frame
    void FixedUpdate()


    {


        /*if (Time.time > 1)
        {
            replay temp = input1[i];
            transform.position = new Vector2(transform.position.x + temp.x * Time.deltaTime * 10f, transform.position.y);
            if (temp.y == 1 && isgrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x,jumpforce);
            }
            i++;
            
        }*/
        if (cloneidnew == 1)
        {
            //transform.position = spwanpoint;
            if (Time.time > 1)
            {
                replay temp = input1[i];
                if (temp.x != 0)
                {
                    animator.SetBool("walking", true);
                }
                else
                {
                    animator.SetBool("walking", false);
                }
                transform.position = new Vector2(transform.position.x + temp.x * Time.fixedDeltaTime * 7f, transform.position.y);
                if (temp.y == 1)
                {
                    if (clonecheck || isgrounded)
                    {
                        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                    }

                }
                i++;

            }
        }
        if (cloneidnew == 2)
        {
            //transform.position = spwanpoint;
            if (Time.time > 1)
            {
                replay temp = input2[k];
                if (temp.x != 0)
                {
                    animator.SetBool("walking", true);
                }
                else
                {
                    animator.SetBool("walking", false);
                }
                transform.position = new Vector2(transform.position.x + temp.x * Time.fixedDeltaTime * 7f, transform.position.y);
                if (temp.y == 1)
                {
                    if (clonecheck || isgrounded)
                    {
                        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                    }
                }
                k++;

            }
        }
        if (cloneidnew == 3)
        {
            if (Time.time > 1)
            {
                replay temp = input3[j];
                if (temp.x != 0)
                {
                    animator.SetBool("walking", true);
                }
                else
                {
                    animator.SetBool("walking", false);
                }
                transform.position = new Vector2(transform.position.x + temp.x * Time.fixedDeltaTime * 7f, transform.position.y);
                if (temp.y == 1)
                {
                    if (clonecheck || isgrounded)
                    {
                        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                    }
                }
                j++;

            }
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
