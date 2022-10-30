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
    private SpriteRenderer[] allChildren;
    public GameObject EnemyDestroyEffect;
    public Material flashWhite;
    private Material defaultMaterial;


    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake(){
        currentHP = maxHP;
        allChildren = GetComponentsInChildren<SpriteRenderer>();
        defaultMaterial = allChildren[0].material;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -=damage;
        foreach(SpriteRenderer child in allChildren)
        {
            StartCoroutine("HitColorAnimation", child);
        }
        if(currentHP<=0)
        {
            GetComponentInParent<Regeneration>().cnt--;
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);

            gameObject.transform.position = new Vector2(100000, 100000);
            GameObject.Find("QuestManager").GetComponent<QuestManager>().Killtrigger();
        }
    }

    private IEnumerator HitColorAnimation(SpriteRenderer sr)
    {
        if(sr!= null)
        {
            sr.material = flashWhite;
        }
        yield return new WaitForSeconds(0.05f);
        if(sr!= null)
        {
            sr.material = defaultMaterial;
        }

       
    }

    public void Regen()
    {
        currentHP = MaxHP;
    }
}
