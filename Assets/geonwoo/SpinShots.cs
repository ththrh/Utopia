using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinShots : MonoBehaviour
{
    public float fireRate = 1f;
    private float nextFireTime;

    //회전되는 스피드이다.
    public float rot_Speed;

    //총알이 발사될 위치이다.
    public Transform pos;

    //발사될 총알 오브젝트이다.
    public GameObject bullet;

    private void Update()
    {
        //회전
        pos.transform.Rotate(Vector3.forward * rot_Speed * 100 * Time.deltaTime);

        //총알 생성
        if (nextFireTime < Time.time)
        {
            GameObject temp = Instantiate(bullet);
            temp.transform.position = pos.transform.position;
            temp.transform.rotation = pos.transform.rotation;
            nextFireTime = Time.time + fireRate;
        }

        //2초후 자동 삭제
        //Destroy(temp, 5f);

        //총알 생성 위치를 머즐 입구로 한다.
        //temp.transform.position = pos.transform.position;

        //총알의 방향을 오브젝트의 방향으로 한다.
        //->해당 오브젝트가 오브젝트가 360도 회전하고 있으므로, Rotation이 방향이 됨.
        //temp.transform.rotation = pos.transform.rotation;
    }
}
