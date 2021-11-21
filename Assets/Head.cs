using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHead : MonoBehaviour
{
    public int dir;
    public float timer = 0.5f;
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
        if (Input.GetMouseButtonDown(0))
        {
            timer = 0.5f;
            rend.color = new Color(0.75f, 0.75f, 0.75f, 1f);
            switch (dir)
            {
                case 1:
                    rend.flipX = false;
                    anim.Play("sword_up");
                    break;
                case 2:
                    rend.flipX = false;
                    anim.Play("sword_down");
                    break;
                case 3:
                    rend.flipX = false;
                    anim.Play("sword_side");
                    break;
                case 4:
                    rend.flipX = true;
                    anim.Play("sword_side");
                    break;
            }
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            rend.color = new Color(0.75f, 0.75f, 0.75f, 0f);
        }
    }
}
