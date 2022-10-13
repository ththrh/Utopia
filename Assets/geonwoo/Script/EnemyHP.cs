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
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
        if(currentHP<=0)
        {

            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
          
            Destroy(gameObject, deathDelay);
            GameObject.Find("QuestManager").GetComponent<QuestManager>().Killtrigger();
        }
    }

    private IEnumerator HitColorAnimation()
    {
        foreach(SpriteRenderer child in allChildren)
        {
            if(child!= null)
            {
                child.material = flashWhite;
            }
            yield return null;
            
        }
        yield return new WaitForSeconds(0.05f);
        foreach(SpriteRenderer child in allChildren)
        {
            if(child!= null)
            {
                child.material = defaultMaterial;
            }
            yield return null;
            
        }

       
    }
}
