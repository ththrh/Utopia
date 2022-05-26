using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShot : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent1;
    public GameObject bulletParent2;
    private Transform player;
    bool facingLeft = true;
    Animator anim;
    // private SpriteRenderer spriterenderer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //spriterenderer.GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }




    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
            anim.SetBool("Running", true);
        }
        else if (distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {

            Instantiate(bullet, bulletParent1.transform.position, Quaternion.identity);
            Instantiate(bullet, bulletParent2.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
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
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }

    void flip()
    {
        facingLeft = !facingLeft;
        transform.Rotate(0, 180, 0);
    }



}