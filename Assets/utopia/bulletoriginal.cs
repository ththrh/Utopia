using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletoriginal : MonoBehaviour
{
    public GameObject target;
    public float speed;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            target = other.gameObject;

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        Destroy(gameObject, 6);

    }

}
