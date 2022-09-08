using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEx : MonoBehaviour
{
    AudioSource audio;
    public float lifetime = 0.66f;
    int atk;
    public int skillAtk;
    // Start is called before the first frame update
    void Start()
    {
        atk = GameObject.FindWithTag("Player").GetComponent<Status>().atk;
        audio = GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<MonsterStatus>().HP -= (atk+skillAtk);
        }
    }

}
