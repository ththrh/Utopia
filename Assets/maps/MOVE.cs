using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public float Speed;
    public float Speed2;
    public float timer = 0f;

    Rigidbody2D rigid;
    float h;
    float v;
    Animator anim;
    SpriteRenderer rend;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        

        bool hdown =  Input.GetButtonDown("Horizontal");
        bool hUP = Input.GetButtonUp("Horizontal");
        bool vdown =  Input.GetButtonDown("Vertical");
        bool vUP = Input.GetButtonUp("Vertical");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isdashed", true);

        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isdashed", false);
        }

         anim.SetInteger("hAxisRaw", (int)h);
         anim.SetInteger("vAxisRaw", (int)v);



        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rend.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rend.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.velocity = new Vector2(h, v) * Speed2;

        }
        else
        {
            rigid.velocity = new Vector2(h, v) * Speed;
        }
    }



    void FixedUpdate()
    {

    }
}
