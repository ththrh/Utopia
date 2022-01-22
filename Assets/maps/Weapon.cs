using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int dir=2;
    public float timer = 0.5f;
    public bool isHead;
    SpriteRenderer rend;
    Animator anim;
    Animator Panim;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isHead)
        { 
            if (Input.GetKey(KeyCode.A))
            {
                dir = 3;
                rend.flipX = false;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir = 3;
                rend.flipX = true;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                dir = 1;
                rend.flipX = false;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir = 2;
                rend.flipX = false;
            }
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                timer = 0.5f;
                rend.color = new Color(0.75f, 0.75f, 0.75f, 1f);
                switch (dir)
                {
                    case 1:
                        anim.Play("sword_up");
                        rend.sortingOrder = 8;
                        break;
                    case 2:
                        anim.Play("sword_down");
                        rend.sortingOrder = 11;
                        break;
                    case 3:
                        anim.Play("sword_side");
                        rend.sortingOrder = 11;
                        break;
                }
            }
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                rend.color = new Color(0.75f, 0.75f, 0.75f, 0f);
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                dir = 0;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir = 2;
            }
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(1))
            {
                timer = 0.5f;
                if (dir == 2)
                {
                    rend.color = new Color(1f, 1f, 1f, 1f);
                    anim.Play("sword_down_cover");
                }
            }
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                rend.color = new Color(0.75f, 0.75f, 0.75f, 0f);
            }
        }

    }
}
