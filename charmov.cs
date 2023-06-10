using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmov : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb1;

    public Rigidbody2D rb2;
    public Rigidbody2D rb3;
    public Transform gr1;
    public Transform gr2;
    public Transform gr3;
    public LayerMask ground;
    private float nextActionTime1 = 0.0f;
    public float period1 = 10f;
    private float nextActionTime2 = 0.0f;
    public float period2 = 10f;
    private float nextActionTime3 = 0.0f;
    public float period3 = 10f;
    public float jumpforce = 7f;
    bool ig1;
    bool ig2;
    bool ig3;

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ig1 = Physics2D.OverlapCapsule(gr1.position, new Vector2(1.52f, 0.21f), CapsuleDirection2D.Horizontal, 0, ground);
        ig2 = Physics2D.OverlapCapsule(gr2.position, new Vector2(1.52f, 0.21f), CapsuleDirection2D.Horizontal, 0, ground);
        ig3 = Physics2D.OverlapCapsule(gr2.position, new Vector2(1.52f, 0.21f), CapsuleDirection2D.Horizontal, 0, ground);
        if (Time.time > nextActionTime1 && ig1)
        {

            nextActionTime1 += period1;
            rb1.velocity = new Vector2(rb1.velocity.x, jumpforce);



        }
        if (Time.time > nextActionTime2 && ig2)
        {

            nextActionTime2 += period2;
            rb2.velocity = new Vector2(rb2.velocity.x, jumpforce);



        }
        if (Time.time > nextActionTime3 && ig3)
        {

            nextActionTime3 += period3;
            rb3.velocity = new Vector2(rb3.velocity.x, jumpforce);



        }


    }
}
