using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStatus : MonoBehaviour
{
    public int HP=3;
    Animator anim;
    SpriteRenderer rend;
    GameObject Player;
    public float deathDelay = 0f;
    public GameObject EnemyDestroyEffect;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            GameObject.Find("QuestManager").GetComponent<QuestManager>().temp_death_count += 1;
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
          
            Destroy(gameObject, deathDelay);
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
