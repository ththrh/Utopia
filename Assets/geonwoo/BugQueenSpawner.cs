using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugQueenSpawner : MonoBehaviour
{
    public GameObject Bug1;
    public GameObject Bug2;
    public GameObject Bug3;


    void SpawnEnemy()
    {

        Vector2 QueenPosition = GameObject.FindWithTag("BugQueen").transform.position; //플레이어 포지션을 가져오는 부분

        float randomX1 = Random.Range(-2.5f, 2.5f);
        float randomX2 = Random.Range(-4.5f, 4.5f);
        float randomX3 = Random.Range(-6.5f, 6.5f);
        float randomY1 = Random.Range(-2.5f, 2.5f); 
        float randomY2 = Random.Range(-4.5f, 4.5f); 
        float randomY3 = Random.Range(-6.5f, 6.5f); 

        GameObject enemy1 = (GameObject)Instantiate(Bug1, new Vector2(QueenPosition.x + randomX1, QueenPosition.y + randomY1), Quaternion.identity);
        GameObject enemy2 = (GameObject)Instantiate(Bug2, new Vector2(QueenPosition.x + randomX2, QueenPosition.y + randomY2), Quaternion.identity);
        GameObject enemy3 = (GameObject)Instantiate(Bug3, new Vector2(QueenPosition.x + randomX3, QueenPosition.y + randomY3), Quaternion.identity);

    }
        // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("SpawnEnemy", 3f, 2f); //3초후 부터, SpawnEnemy함수를 2초마다 반복해서 실행 시킵니다.
    }

    // Update is called once per frame
    void Update()
    {
     
    }



}
