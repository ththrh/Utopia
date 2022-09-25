﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossState { Phase01}

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private BossState bossState = BossState.Phase01;

    private BossWeaponSystem bossWeapon;

    private void Awake() 
    {
        
        bossWeapon = GetComponent<BossWeaponSystem>();
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
            yield return null;
        }
    }
}