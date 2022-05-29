using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public int HP=3;
    Animator anim;
    SpriteRenderer rend;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            anim.Play("Death");

            Destroy(gameObject, 0.7f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAtk"))
        {
            HP -= Player.GetComponent<Status>().atk;
        }
    }
}
