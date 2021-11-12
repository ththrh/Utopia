using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterattack : MonoBehaviour
{
    public GameObject bullet;
    public bool isfire = false;
    public GameObject target;


    private float firerate = 1f;
    private float nextfire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            isfire = true;
            target = other.gameObject;

        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isfire = true;

        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isfire = false;

        }

    }
    // Update is called once per frame
    void Update()
    {
        if(isfire == true&& Time.time>nextfire)
        {
            nextfire = Time.time + firerate;
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
