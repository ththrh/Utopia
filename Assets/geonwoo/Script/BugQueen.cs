using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugQueen : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    private Transform player;
    bool facingLeft = true;
    Animator anim;
    public GameObject bullet;
    public GameObject bulletParent;
    private float nextFireTime;
    public float fireRate = 1f;

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

        if (nextFireTime < Time.time)
        {
            shot();
            nextFireTime = Time.time + fireRate;
        }


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }


    void flip()
    {
        facingLeft = !facingLeft;
        transform.Rotate(0, 180, 0);
    }

    void shot()
    {
        //360번 반복
        for (int i = 0; i < 360; i += 13)
        {
            
            
            if (nextFireTime < Time.time)
            {
                //총알 생성
                GameObject temp = Instantiate(bullet);
                

                Destroy(temp, 2f);

                //총알 생성 위치를 (0,0) 좌표로 한다.
                temp.transform.position = bulletParent.transform.position;

                //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
                temp.transform.rotation = Quaternion.Euler(0, 0, i);

                
            }
         
        }
    }

}

