using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q_skill : MonoBehaviour
{
    public Status stat;
    public Sprite[] SkillImage;
    Dictionary<int, Sprite> q_skilldata;

    void Awake()
    {
        q_skilldata = new Dictionary<int, Sprite>();
        makedata();
    }
    void makedata()
    {
        q_skilldata.Add(0, SkillImage[0]);
        q_skilldata.Add(1, SkillImage[1]);
        q_skilldata.Add(2, SkillImage[2]);
        q_skilldata.Add(3, SkillImage[3]);
        q_skilldata.Add(4, SkillImage[3]);

    }
    public void Learn_q_Skill_1()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.q_islearnskill_1)
            {
                stat.q_islearnskill_1 = true;
                stat.q_islearnskill_2 = false;
                stat.q_islearnskill_3 = false;
                stat.q_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }

            else
                return;
        }
        else
            return;
    }
    public void Learn_q_Skill_2()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.q_islearnskill_2)
            {
                stat.q_islearnskill_1 = false;
                stat.q_islearnskill_2 = true;
                stat.q_islearnskill_3 = false;
                stat.q_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }
        else
            return;

    }
    public void Learn_q_Skill_3()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.q_islearnskill_3)
            {
                stat.q_islearnskill_1 = false;
                stat.q_islearnskill_2 = false;
                stat.q_islearnskill_3 = true;
                stat.q_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }

        else
            return;
    }

    public void Learn_q_Skill_4()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.q_islearnskill_4)
            {
                stat.q_islearnskill_1 = false;
                stat.q_islearnskill_2 = false;
                stat.q_islearnskill_3 = false;
                stat.q_islearnskill_4 = true;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }

        else
            return;
    }
    public Sprite Getskillimage(int skillIndex)
    {
        return q_skilldata[skillIndex];
    }
}
