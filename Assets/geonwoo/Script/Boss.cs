using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    private BossHP bossHP;

    [SerializeField]
    private GameObject gunpoint1;
    [SerializeField]
    private GameObject gunpoint2;
    [SerializeField]
    private GameObject gunpoint3;


    private void Awake() 
    {
        bossHP = GetComponent<BossHP>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if(bossHP.CurrentHP<= bossHP.MaxHP * 0.7f)
        {
            gunpoint1.SetActive(false);
            gunpoint2.SetActive(true);
        }
        if(bossHP.CurrentHP<= bossHP.MaxHP * 0.3f)
        {
            gunpoint2.SetActive(false);
            gunpoint3.SetActive(true);
        }

    }
    
    
}