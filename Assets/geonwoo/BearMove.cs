using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMove : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float AttackRange;
    private Transform player;
    bool facingLeft = true;
    Animator anim;
  

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
        
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }

        if (player.position.x > transform.position.x && facingLeft == true)
        {
            flip();
        }
        if (player.position.x < transform.position.x && facingLeft == false)
        {
            flip();
        }

        if (distanceFromPlayer < AttackRange)
        {
            anim.SetTrigger("Attack");
        }
        

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }


    void flip()
    {
        facingLeft = !facingLeft;
        transform.Rotate(0, 180, 0);
    }


}

