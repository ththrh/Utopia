using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyFollowPlayer : MonoBehaviour
{

    private Transform player;

    Animator anim;

    public MOVE Player;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MOVE>().isdarksight == false)
        {
            float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
          
        }


    }

}

