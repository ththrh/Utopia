using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{


    [SerializeField]
    private float maxHP = 1000;
    private float currentHP;
    public float deathDelay = 0f;
    Animator anim;
    private SpriteRenderer spriteRenderer;
    public GameObject EnemyDestroyEffect;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake(){
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -=damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
        if(currentHP<=0)
        {
            GameObject.Find("QuestManager").GetComponent<QuestManager>().temp_death_count += 1;
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
          
            Destroy(gameObject, deathDelay);
        }
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = Color.white;
    }
}
