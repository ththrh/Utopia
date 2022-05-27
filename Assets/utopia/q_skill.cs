using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q_skill : MonoBehaviour
{
    public Status stat;
    public tooltip_manager tooltip_;


    public GameObject learn_mark_1;
    public GameObject learn_mark_2;
    public GameObject learn_mark_3;
    public GameObject learn_mark_4;
    public void Learn_q_Skill_1()
    {
        if (!stat.q_islearnskill_1)


        {
            if (stat.SkillPoint > 0)
            {
                stat.q_islearnskill_1 = true;
                stat.q_isactiveskill_1 = true;
                stat.q_isactiveskill_2 = false;
                stat.q_isactiveskill_3 = false;
                stat.q_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_1.SetActive(true);
            }
        }
        else if (stat.q_islearnskill_1)
        {
            stat.q_isactiveskill_1 = true;
            stat.q_isactiveskill_2 = false;
            stat.q_isactiveskill_3 = false;
            stat.q_isactiveskill_4 = false;
        }
        else
            return;
    }

    public void Learn_q_Skill_2()
    {
        if (!stat.q_islearnskill_2)


        {
            if (stat.SkillPoint > 0)
            {
                stat.q_islearnskill_2 = true;
                stat.q_isactiveskill_1 = false;
                stat.q_isactiveskill_2 = true;
                stat.q_isactiveskill_3 = false;
                stat.q_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_2.SetActive(true);
            }
        }
        else if (stat.q_islearnskill_2)
        {
            stat.q_isactiveskill_1 = false;
            stat.q_isactiveskill_2 = true;
            stat.q_isactiveskill_3 = false;
            stat.q_isactiveskill_4 = false;
        }
        else
            return;
    }
    public void Learn_q_Skill_3()
    {
        if (!stat.q_islearnskill_3)


        {
            if (stat.SkillPoint > 0)
            {
                stat.q_islearnskill_3 = true;
                stat.q_isactiveskill_1 = false;
                stat.q_isactiveskill_2 = false;
                stat.q_isactiveskill_3 = true;
                stat.q_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_3.SetActive(true);
            }
        }
        else if (stat.q_islearnskill_3)
        {
            stat.q_isactiveskill_1 = false;
            stat.q_isactiveskill_2 = false;
            stat.q_isactiveskill_3 = true;
            stat.q_isactiveskill_4 = false;
        }
        else
            return;
    }
    public void Learn_q_Skill_4()
    {
        if (!stat.q_islearnskill_4)


        {
            if (stat.SkillPoint > 0)
            {
                stat.q_islearnskill_4 = true;
                stat.q_isactiveskill_1 = false;
                stat.q_isactiveskill_2 = false;
                stat.q_isactiveskill_3 = false;
                stat.q_isactiveskill_4 = true;
                stat.SkillPoint -= 1;

                learn_mark_4.SetActive(true);
            }
        }
        else if (stat.q_islearnskill_4)
        {
            stat.q_isactiveskill_1 = false;
            stat.q_isactiveskill_2 = false;
            stat.q_isactiveskill_3 = false;
            stat.q_isactiveskill_4 = true;
        }
        else
            return;
    }

    public void tooltip_zero()
    {
        tooltip_.trigger = 0;
    }
    public void tooltip_9()
    {
        tooltip_.trigger = 9;
    }
    public void tooltip_10()
    {
        tooltip_.trigger = 10;
    }
    public void tooltip_11()
    {
        tooltip_.trigger = 11;
    }
    public void tooltip_12()
    {
        tooltip_.trigger = 12;
    }
}
