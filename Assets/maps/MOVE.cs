using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public float Speed;

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


        anim.SetInteger("hAxisRaw",(int)h);
        anim.SetInteger("vAxisRaw",(int)v);

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rend.flipX = true;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rend.flipX = false;
        }

    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(h, v) * Speed;
    }
}
