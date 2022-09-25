using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossState { Phase01=0,Phase02=1}


public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private BossState bossState;
    private BossHP bossHP;

    private BossWeaponSystem bossWeapon;

    private void Awake() 
    {
        
        bossWeapon = GetComponent<BossWeaponSystem>();
        bossHP = GetComponent<BossHP>();
    }

    private void Start()
    {
        StartCoroutine("Phase01");
    }
    

    public void ChangeState(BossState newState)
    {
        StopCoroutine(bossState.ToString());

        bossState = newState;

        StartCoroutine(bossState.ToString());
    }

    private IEnumerator Phase01()
    {
        bossWeapon.StartFiring(AttackType.CircleFire);

        while(true)
        {
            Debug.Log("ggg");
            if(bossHP.CurrentHP <= bossHP.MaxHP *0.7f)
            {
                bossWeapon.StopFiring(AttackType.CircleFire);

                ChangeState(BossState.Phase02);
            }
            yield return null;
        }
    }

    private IEnumerator Phase02()
    {
        Debug.Log("shower");
        bossWeapon.StartFiring(AttackType.Shower);


        while(true)
        {
            yield return null;
        }
    }
}