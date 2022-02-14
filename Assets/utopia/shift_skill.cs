using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shift_skill : MonoBehaviour
{
    public Status stat;
    public Sprite[] SkillImage;
    Dictionary<int, Sprite> shift_skilldata;

    void Awake()
    {
        shift_skilldata = new Dictionary<int, Sprite>();
        makedata();
    }
    void makedata()
    {
        shift_skilldata.Add(0, SkillImage[0]);
        shift_skilldata.Add(1, SkillImage[1]);
        shift_skilldata.Add(2, SkillImage[2]);
        shift_skilldata.Add(3, SkillImage[3]);
        shift_skilldata.Add(4, SkillImage[4]);

    }
    public void Learn_shift_Skill_1()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.shift_islearnskill_1)
            {
                stat.shift_islearnskill_1 = true;
                stat.shift_islearnskill_2 = false;
                stat.shift_islearnskill_3 = false;
                stat.shift_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }

            else
                return;
        }
        else
            return;
    }
    public void Learn_shift_Skill_2()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.shift_islearnskill_2)
            {
                stat.shift_islearnskill_1 = false;
                stat.shift_islearnskill_2 = true;
                stat.shift_islearnskill_3 = false;
                stat.shift_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }
        else
            return;

    }
    public void Learn_shift_Skill_3()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.shift_islearnskill_3)
            {
                stat.shift_islearnskill_1 = false;
                stat.shift_islearnskill_2 = false;
                stat.shift_islearnskill_3 = true;
                stat.shift_islearnskill_4 = false;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }

        else
            return;
    }

    public void Learn_shift_Skill_4()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.shift_islearnskill_4)
            {
                stat.shift_islearnskill_1 = false;
                stat.shift_islearnskill_2 = false;
                stat.shift_islearnskill_3 = false;
                stat.shift_islearnskill_4 = true;
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
        return shift_skilldata[skillIndex];
    }
}
