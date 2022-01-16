using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float ShotSpeed = 3.0f;
    public float shotTime;
    Status stat;
    void Start()
    {
        stat = GetComponentInParent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rot;

        if (Input.GetMouseButtonDown(1) && stat.Mp > 0)
        {
            if(Time.time >= shotTime)
            {
                stat.Mp -= 1;
                Instantiate(bullet, transform.position, Quaternion.AngleAxis(angle-90, Vector3.forward));
                GetComponent<AudioSource>().Play();
            }
        }
    }
}