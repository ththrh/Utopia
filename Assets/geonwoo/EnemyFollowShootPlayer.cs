using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowShootPlayer : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent;
    private Transform player;
    public int patternIndex;
    public float rot_Speed;
    public Transform pos;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {
            //원형 발사 후 추적
            var bl = new List<Transform>();

            for (int i = 0; i < 360; i += 13)
            {
                //총알 생성
                var temp = Instantiate(bullet);

                //2초후 삭제
                Destroy(temp, 2f);

                //총알 생성 위치를 (0,0) 좌표로 한다.
                temp.transform.position = bulletParent.transform.position;

                //?초후에 Target에게 날아갈 오브젝트 수록
                bl.Add(temp.transform);

                //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
                temp.transform.rotation = Quaternion.Euler(0, 0, i);
            }
            //총알을 Target 방향으로 이동시킨다.
            StartCoroutine(BulletToTarget(bl));


            //원형 발사
            //for (int i = 0; i < 360; i += 13)
            //{
            //    //총알 생성
            //    GameObject temp = Instantiate(bullet);

            //    //2초마다 삭제
            //    Destroy(temp, 2f);

            //    //총알 생성 위치를 (0,0) 좌표로 한다.
            //    temp.transform.position = bulletParent.transform.position;

            //    //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
            //    temp.transform.rotation = Quaternion.Euler(0, 0, i);
            //}



            //그냥 발사
            //Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            //Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }
    IEnumerator BulletToTarget(List<Transform> bl)
    {
        //0.5초 후에 시작
        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < bl.Count; i++)
        {
            //현재 총알의 위치에서 플레이의 위치의 벡터값을 뻴셈하여 방향을 구함
            var target_dir = target.transform.position - bl[i].position;

            //x,y의 값을 조합하여 Z방향 값으로 변형함. -> ~도 단위로 변형
            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg;

            //Target 방향으로 이동
            bl[i].rotation = Quaternion.Euler(0, 0, angle);
        }

        //데이터 해제
        bl.Clear();
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}


