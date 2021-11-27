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
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                timer = 0.5f;
                rend.color = new Color(0.75f, 0.75f, 0.75f, 1f);
                switch (dir)
                {
                    case 1:
                        rend.flipX = false;
                        anim.Play("sword_up");
                        rend.sortingOrder = 8;
                        break;
                    case 2:
                        rend.flipX = false;
                        anim.Play("sword_down");
                        rend.sortingOrder = 11;
                        break;
                    case 3:
                        rend.flipX = false;
                        anim.Play("sword_side");
                        rend.sortingOrder = 11;
                        break;
                    case 4:
                        rend.flipX = true;
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
            if (Input.GetKeyDown(KeyCode.S))
            {
                dir = 2;
            }
            else if(Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                dir = 0;
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
