using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFollowBite : MonoBehaviour
{
    public float AttackRange;
    private Transform player;
    bool facingLeft = true;
    Animator anim;
    UnityEngine.AI.NavMeshAgent nav;

    MOVE Player;
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

            anim.SetBool("Running", true);

            if (distanceFromPlayer < AttackRange)
            {
                anim.SetTrigger("Attack");
            }

        }


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }

}
