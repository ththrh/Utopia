using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowDash : MonoBehaviour
{
    public float speed;
    public float dashspeed;
    public float lineOfSite;
    public float DashRange;
    private bool canDash = false;
    private Transform player;
    //public float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > DashRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= DashRange && canDash)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, dashspeed * Time.deltaTime);
            canDash = false;
            StartCoroutine(DashToPlayer());
        }
    }
    IEnumerator DashToPlayer()
    {
        yield return new WaitForSeconds(5f);
        canDash = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, DashRange);
    }
}

