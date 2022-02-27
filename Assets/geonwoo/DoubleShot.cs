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
    // private SpriteRenderer spriterenderer;

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
        }
        else if (distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {

            Instantiate(bullet, bulletParent1.transform.position, Quaternion.identity);
            Instantiate(bullet, bulletParent2.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}