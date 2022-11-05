using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    float atkTimer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Run Animation
        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetKey(KeyCode.A))
            {
                rend.flipX = false;
            }
            else
            {
                rend.flipX = true;
            }
            anim.SetInteger("Dir", 1);
            anim.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rend.flipX = false;
            anim.SetInteger("Dir", 0);
            anim.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rend.flipX = false;
            anim.SetInteger("Dir", 2);
            anim.SetBool("isRun", true);
        }

        //Stop Running
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isRun", false);
        }

        //Slide Animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Slide");
        }

        //Attack Animation
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && atkTimer == 1)
        {
            atkTimer -= Time.deltaTime;
            Debug.Log("bow animation");
            switch (anim.GetInteger("Dir"))
            {
                case 0:
                    anim.Play("sword_down");
                    break;
                case 1:
                    anim.Play("sword_side");
                    break;
                case 2:
                    anim.Play("sword_up");
                    break;
            }
        }
        if(atkTimer != 1)
        {
            atkTimer -= Time.deltaTime;
        }
        if(atkTimer < 0)
        {
            atkTimer = 1f;
        }
    }
}
