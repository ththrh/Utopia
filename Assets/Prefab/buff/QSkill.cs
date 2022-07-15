using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QSkill : MonoBehaviour
{
    Status stat;
    float regenTime = 0;
    bool speedUp = false;
    bool qCool = false;

    public ParticleSystem ManaHeal;


    // Start is called before the first frame update
    void Start()
    {
        stat = GetComponentInParent<Status>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (stat.q_isactiveskill_1 && !qCool)
            {
                qCool = true;
                StartCoroutine(qCooldown(20f));
                stat.Mp = stat.MaxMp;
                ManaHeal.Play();
            }
            else if (stat.q_isactiveskill_2 && !qCool)
            {
                qCool = true;
                StartCoroutine("Atkup");

            }
            else if (stat.q_isactiveskill_3 && !qCool)
            {
                qCool = true;
                StartCoroutine("Speedup");
            }
        }
        if (stat.q_isactiveskill_4)
        {
            regenTime += Time.deltaTime;
            if (regenTime >= 5)
            {
                regenTime = 0;
                if (stat.hp < stat.MaxHp)
                {
                    stat.hp += 1;
                }
            }
        }
    }

    IEnumerator Speedup()
    {
        stat.speed += 2;
        yield return new WaitForSeconds(5f);
        qCool = false;
        stat.speed -= 2;
    }
    IEnumerator Atkup()
    {
        stat.atk += 1;
        yield return new WaitForSeconds(3f);
        qCool = false;
        stat.atk -= 1;
    }

    IEnumerator qCooldown(float f)
    {
        yield return new WaitForSeconds(f);
        qCool = false;
    }
}
