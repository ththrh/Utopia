using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int MaxHp = 5;
    public int hp = 5;
    public int MaxStamina = 5;
    public int Stamina;
    public int MaxMp = 5;
    public int Mp;
    public int atk = 1;
    public int speed = 2;
    public int dash = 8;
    public bool isDamage;
    public float Dtimer=1.0f;
    public GameObject DeadUI;
    float timer;
    SpriteRenderer rend;
    MOVE move;
    Vector2 deadPos;
    float MpRegen;
    float StaminaRestore = 5.0f;

    public int SkillPoint;

    public bool click_islearnskill_1;
    public bool click_islearnskill_2;
    public bool click_islearnskill_3;
    public bool click_islearnskill_4;

    public bool shift_islearnskill_1;
    public bool shift_islearnskill_2;
    public bool shift_islearnskill_3;
    public bool shift_islearnskill_4;

    public bool q_islearnskill_1;
    public bool q_islearnskill_2;
    public bool q_islearnskill_3;
    public bool q_islearnskill_4;


    public bool click_isactiveskill_1;
    public bool click_isactiveskill_2;
    public bool click_isactiveskill_3;
    public bool click_isactiveskill_4;

    public bool shift_isactiveskill_1;
    public bool shift_isactiveskill_2;
    public bool shift_isactiveskill_3;
    public bool shift_isactiveskill_4;

    public bool q_isactiveskill_1;
    public bool q_isactiveskill_2;
    public bool q_isactiveskill_3;
    public bool q_isactiveskill_4;

    public Image youdie;



    // Start is called before the first frame update
    void Start()
    {
        timer = Dtimer;
        rend = GetComponent<SpriteRenderer>();
        move = GetComponent<MOVE>();
        hp = MaxHp;
        Stamina = MaxStamina;
        Mp = MaxMp;
        StartCoroutine("mpRegeneration");

    }

    // Update is called once per frame
    void Update()
    {
        if (isDamage)
        {
            Dtimer -= Time.deltaTime;
        }
        if (Dtimer <= 0)
        {
            Dtimer = timer;
            isDamage = false;
        }
        if (StaminaRestore > 0)
        {
            StaminaRestore -= Time.deltaTime;
        }
        else
        {
            StaminaRestore = 5.0f;
            Stamina += 1;
        }

        if (Input.GetKey(KeyCode.P))
        {
            if (Input.GetKey(KeyCode.O))
            {
                if (Input.GetKey(KeyCode.I))
                {
                    Cheat();
                }
            }
        }
        if (hp <= 0)
        {
            hp = MaxHp;
            StartCoroutine("youDie");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && !isDamage && !move.isshield && !move.isDash)
        {
            isDamage = true;
            hp -= 1;
        }
        if(collision.CompareTag("Bullet") && !isDamage && !move.isshield && !move.isDash)
        {
            isDamage = true;
            hp -= 1;
            StartCoroutine(UnBeatTime());
        }
        if (collision.CompareTag("Teleporter"))
        {
            deadPos = transform.position;
        }
    }

    IEnumerator UnBeatTime()
    {
        int cnt = 0;
        for(cnt=0; cnt<=10; cnt++)
        {
            if (cnt % 2 == 0)
            {
                rend.color = new Color32(255, 255, 255, 90);
            }
            else
            {
                rend.color = new Color32(255, 255, 255, 180);
            }
            yield return new WaitForSeconds(0.1f);

        }
        rend.color = new Color32(255, 255, 255, 255);
        yield return null;
    }

    IEnumerator youDie()
    {
        DeadUI.SetActive(true);
        transform.position = deadPos;
        Time.timeScale = 0;
        Mp = MaxMp;
        yield return null;
    }

    IEnumerator mpRegeneration()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Mp += 2;
            if (Mp > MaxMp) Mp = MaxMp;
        }
    }

    private void Cheat()
    {
        MaxHp = 1000000000;
        hp = 100000000;
        MaxStamina = 10000000;
        Stamina = 100000;
        MaxMp = 100000;
        Mp = 100000;
        atk = 1000;
        speed = 15;
        dash = 60;

    }
}
