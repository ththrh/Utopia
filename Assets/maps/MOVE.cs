﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Dir
{
    public const int up = 1;
    public const int down = 2;
    public const int left = 3;
    public const int right = 4;
}

public class MOVE : MonoBehaviour
{

    Vector3 dirVec;
    GameObject scanobj;
    public GameManager manager;

    public float Speed;
    public float Speed2;
    public float timer = 0.2f;

    public bool isAttack = false;
    bool isDash = false;
    public float atktimer = 0.7f;
    int dir = 2;
    Rigidbody2D rigid;
    float h;
    float v;
    Animator anim;
    SpriteRenderer rend;
    Status stat;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        stat = GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {


        if (!isDash && !manager.isAction && !isAttack)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
            rigid.velocity = new Vector2(h, v) * Speed;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }
        

         anim.SetInteger("hAxisRaw", (int)h);
         anim.SetInteger("vAxisRaw", (int)v);


        
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)) && !isAttack)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(Input.GetKeyDown(KeyCode.D) && !isAttack)
        {
            dirVec = Vector3.right;
            dir = Dir.right;
            rend.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.A) && !isAttack)
        {
            dirVec = Vector3.left;
            dir = Dir.left;
            rend.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.W) && !isAttack)
        {
            rend.flipX = false;
            dirVec = Vector3.up;
            dir = Dir.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && !isAttack)
        {
            rend.flipX = false;
            dirVec = Vector3.down;
            dir = Dir.down;
        }
        //대쉬
        if (Input.GetKeyDown(KeyCode.Space) && !isAttack && stat.Stamina > 0)
        {
            if(!isDash)
            {
                stat.Stamina -= 1;
                isDash = true;
                anim.SetTrigger("isDashed");
            }
        }
        if (isDash)
        {
            transform.Translate(new Vector3(h * Speed2, v * Speed2, 0) * Time.deltaTime);
        }
        if (isDash && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = 0.2f;
            isDash = false;
        }

        transform.gameObject.GetComponentInChildren<Weapon>().dir = dir;
        if ((Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1)) && !manager.isAction)
        {
            isAttack = true;
            anim.SetBool("isRunning", false);
            switch (dir)
            {
                case Dir.up:
                    anim.Play("sword_up");
                    break;
                case Dir.down:
                    anim.Play("sword_down");
                    break;
                case Dir.left:
                case Dir.right:
                    anim.Play("sword_side");
                    break;
            }
        }
        if (isAttack)
        {
            atktimer -= Time.deltaTime;
            if (atktimer <= 0)
            {
                isAttack = false;
                atktimer = 0.7f;
            }
        }

        if(Input.GetKeyDown(KeyCode.E)&&scanobj!=null)
        {
            manager.Action(scanobj);
        }


    }



    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, dirVec * 1f, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 1f,LayerMask.GetMask("obj" ));

        if (rayHit.collider != null)
        {
            scanobj = rayHit.collider.gameObject;
        }
        else
            scanobj = null;

    }


}
