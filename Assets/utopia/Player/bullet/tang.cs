using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tang : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
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
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log(1);
            Destroy(gameObject);
        }
    }
}
