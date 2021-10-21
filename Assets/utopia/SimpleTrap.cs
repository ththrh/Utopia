using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrap : MonoBehaviour
{
    Rigidbody2D rigid;
    BoxCollider2D col;

    bool isAcitve = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!isAcitve)
        {
            if (other.tag == "Player")
            {
                isAcitve = true;
                Debug.Log("trap");
                isAcitve = false;

            }
            else
                isAcitve = false;
        }

    }
}
