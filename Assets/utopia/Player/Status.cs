using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public int hp = 5;
    public bool isDamage;
    public float Dtimer=1.0f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = Dtimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDamage)
        {
            Dtimer -= Time.deltaTime;
        }
        if (Dtimer <= 0)
        {
            Dtimer = timer;
            isDamage = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && !isDamage)
        {
            isDamage = true;
            hp -= 1;
        }
        if(collision.CompareTag("Bullet") && !isDamage)
        {
            isDamage = true;
            hp -= 1;
        }
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision);
        }
    }
}
