using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    //GameObject target;
    //public float speed;
    //Rigidbody2D bulletRB;

    //void Start()
    //{
    //    bulletRB = GetComponent<Rigidbody2D>();

    //    target = GameObject.FindGameObjectWithTag("Player");
    //    Vector3 Dir = new Vector3(1, 1,1);
    //    Vector2 moveDir = (target.transform.position - transform.position + Dir).normalized* speed;

    //    bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);

    //    Destroy(this.gameObject, 2);

    //}
    public float speed = 10f;

    private void Start()
    {
        //생성으로부터 2초 후 삭제
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        //두번째 파라미터에 Space.World를 해줌으로써 Rotation에 의한 방향 오류를 수정함
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self);
    }


}
