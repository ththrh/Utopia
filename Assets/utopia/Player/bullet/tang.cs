using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tang : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    int atk;
    // Start is called before the first frame update
    void Start()
    {

        atk = GameObject.FindWithTag("Player").GetComponent<Status>().atk;
        transform.Rotate(0, 0, 90);
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime) ;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<MonsterStatus>().HP -= (atk);
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("Boss")){
            collision.gameObject.GetComponent<BossHP>().TakeDamage(atk);
            Destroy(gameObject);
        }
    }
}
