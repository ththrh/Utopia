using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrow;
    public GameObject bullet;
    public GameObject bomb;
    public GameObject UCB;
    public GameObject SA;
    public float ShotSpeed = 3.0f;
    public float shotTime;
    Status stat;
    bool isAttack = false;

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
            if (stat.click_isactiveskill_1)
            {
                if (Time.time >= shotTime)
                {
                    stat.Mp -= 1;
                    Instantiate(bullet, transform.position, Quaternion.AngleAxis(angle - 90, Vector3.forward));
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (stat.click_isactiveskill_2)
            {
                stat.Mp -= 1;
                Instantiate(bomb, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.AngleAxis(0, Vector3.forward));
                GetComponent<AudioSource>().Play();
            }
            else if (stat.click_isactiveskill_3)
            {
                stat.Mp -= 1;
                Instantiate(UCB, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.AngleAxis(0, Vector3.forward));
                GetComponent<AudioSource>().Play();
            }
        }
        if (stat.click_isactiveskill_4)
        {
            if (Input.GetMouseButton(1) && stat.Mp>0)
            {
                if (!isAttack)
                {
                    isAttack = true;
                    stat.Mp -= 1;
                    Instantiate(SA, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
                    StartCoroutine("timecheck");
                    GetComponent<AudioSource>().Play();
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time >= shotTime)
            {
                Instantiate(arrow, transform.position, Quaternion.AngleAxis(angle-90, Vector3.forward));
                GetComponent<AudioSource>().Play();
            }
        }
    }

    IEnumerator timecheck()
    {
        yield return new WaitForSeconds(0.25f);
        isAttack = false;
    }
}