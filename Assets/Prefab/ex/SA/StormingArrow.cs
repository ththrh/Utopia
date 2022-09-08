using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormingArrow : MonoBehaviour
{
    [SerializeField] [Header("이동거리")] [Range(1f,9f)] float dist = 7f;
    [SerializeField] [Header("이동속도")] [Range(1f, 50f)] float speed = 5f;
    [SerializeField] [Header("파동빈도")] [Range(1f, 40f)] float frequency = 5f;
    [SerializeField] [Header("파동높이")] [Range(0.2f, 4f)] float waveHeight = 5f;
    AudioSource audio;
    
    Vector3 pos, localScale;
    int atk;
    bool dirright = false;

    // Start is called before the first frame update
    void Start()
    {
        atk = GameObject.FindWithTag("Player").GetComponent<Status>().atk;
        audio = GetComponent<AudioSource>();
        pos = transform.position;
        localScale = transform.localScale;
        audio.Play();
        Destroy(gameObject, 3f);
    }
    private void Update()
    {
        go();
    }
    void go()
    {
        pos += transform.right * Time.deltaTime * speed;
        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<MonsterStatus>().HP -= (atk + 1) ;
            Debug.Log(1);
            transform.position = new Vector3(-124121, 123155, 0);
            Destroy(gameObject);
        }
    }
}
