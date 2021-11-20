using System.Collections;
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

    bool isDash = false;
    int dir;
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
        

        if (!isDash)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
            rigid.velocity = new Vector2(h, v) * Speed;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
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
            dirVec = Vector3.right;
            dir = Dir.right;
            rend.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dirVec = Vector3.left;
            dir = Dir.left;
            rend.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dirVec = Vector3.up;
            dir = Dir.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dirVec = Vector3.down;
            dir = Dir.down;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isDash)
            {
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
        if (Input.GetMouseButtonDown(0))
        {
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
