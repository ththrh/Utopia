using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDash : MonoBehaviour
{
    float atkDistance = 4f;
    GameObject player;
    public float speed = 5f;
    public bool canDash = true;
    Vector2 Dir;
    float dashTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < atkDistance && canDash)
        {
            Dir = player.transform.position - transform.position;
            canDash = false;
        }
        if (!canDash)
        {
            transform.position += (Vector3)Dir.normalized * speed * Time.deltaTime;
            dashTime -= Time.deltaTime;
        }
        if (dashTime <= 0)
        {
            canDash = true;
            dashTime = 1f;
        }
    }
}
