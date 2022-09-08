using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSkill : MonoBehaviour
{
    public GameObject explosion;
    AudioSource audio;
    int atk;
    // Start is called before the first frame update
    void Start()
    {
        atk = GameObject.FindWithTag("Player").GetComponent<Status>().atk;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        { 
            Instantiate(explosion, transform.position, transform.rotation);
            collision.gameObject.GetComponent<MonsterStatus>().HP -= (atk*2);
            audio.Play();
            transform.position = new Vector3(-128442, 124124, 1231);
            Debug.Log("펑");
            Destroy(gameObject,1f);
        }
    }
}
