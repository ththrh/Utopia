using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooltimer_q : MonoBehaviour
{
    public QSkill QQ;
    public Text cooltimertxt;
    public MOVE move;
    public Status stat;

    float qcooltime1 = 20;
    float qcooltime2 = 3;
    float qcooltime3 = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stat.q_isactiveskill_1)
        {
            if(!QQ.qCool)
            {
                cooltimertxt.text = ("");
            }
            else
            {
                qcooltime1 -= Time.deltaTime;
                cooltimertxt.text = qcooltime1.ToString("F0");
                if (qcooltime1 < 0)
                    qcooltime1 = 20;
            }
                
        }
        if (stat.q_isactiveskill_2)
        {
            if (!QQ.qCool)
            {
                cooltimertxt.text = ("");
            }
            else
            {
                qcooltime2 -= Time.deltaTime;
                cooltimertxt.text = qcooltime2.ToString("F0");
                if (qcooltime2 < 0)
                    qcooltime2 = 3;
            }

        }
        if (stat.q_isactiveskill_3)
        {
            if (!QQ.qCool)
            {
                cooltimertxt.text = ("");
            }
            else
            {
                qcooltime3 -= Time.deltaTime;
                cooltimertxt.text = qcooltime3.ToString("F0");
                if (qcooltime3 < 0)
                    qcooltime3 = 5;
            }

        }
    }
}
