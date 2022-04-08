using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shift_skill : MonoBehaviour
{
    public Status stat;
    public tooltip_manager tooltip_;

    public GameObject learn_mark_1;
    public GameObject learn_mark_2;
    public GameObject learn_mark_3;
    public GameObject learn_mark_4;


    public void Learn_shift_Skill_1()
    {
        if (!stat.shift_islearnskill_1)


        {
            if (stat.SkillPoint > 0)
            {
                stat.shift_islearnskill_1 = true;
                stat.shift_isactiveskill_1 = true;
                stat.shift_isactiveskill_2 = false;
                stat.shift_isactiveskill_3 = false;
                stat.shift_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_1.SetActive(true);
            }
        }
        else if (stat.shift_islearnskill_1)
        {
            stat.shift_isactiveskill_1 = true;
            stat.shift_isactiveskill_2 = false;
            stat.shift_isactiveskill_3 = false;
            stat.shift_isactiveskill_4 = false;
        }

    }

    public void Learn_shift_Skill_2()
    {
        if (!stat.shift_islearnskill_2)


        {
            if (stat.SkillPoint > 0)
            {
                stat.shift_islearnskill_2 = true;
                stat.shift_isactiveskill_1 = false;
                stat.shift_isactiveskill_2 = true;
                stat.shift_isactiveskill_3 = false;
                stat.shift_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_2.SetActive(true);
            }
        }
        else if (stat.shift_islearnskill_2)
        {
            stat.shift_isactiveskill_1 = false;
            stat.shift_isactiveskill_2 = true;
            stat.shift_isactiveskill_3 = false;
            stat.shift_isactiveskill_4 = false;
        }

    }
    public void Learn_shift_Skill_3()
    {
        if (!stat.shift_islearnskill_3)


        {
            if (stat.SkillPoint > 0)
            {
                stat.shift_islearnskill_3 = true;
                stat.shift_isactiveskill_1 = false;
                stat.shift_isactiveskill_2 = false;
                stat.shift_isactiveskill_3 = true;
                stat.shift_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_3.SetActive(true);
            }
        }
        else if (stat.shift_islearnskill_3)
        {
            stat.shift_isactiveskill_1 = true;
            stat.shift_isactiveskill_2 = false;
            stat.shift_isactiveskill_3 = false;
            stat.shift_isactiveskill_4 = false;
        }

    }
    public void Learn_shift_Skill_4()
    {
        if (!stat.shift_islearnskill_4)


        {
            if (stat.SkillPoint > 0)
            {
                stat.shift_islearnskill_4 = true;
                stat.shift_isactiveskill_1 = false;
                stat.shift_isactiveskill_2 = false;
                stat.shift_isactiveskill_3 = false;
                stat.shift_isactiveskill_4 = true;
                stat.SkillPoint -= 1;

                learn_mark_4.SetActive(true);
            }
        }
        else if (stat.shift_islearnskill_4)
        {
            stat.shift_isactiveskill_1 = false;
            stat.shift_isactiveskill_2 = false;
            stat.shift_isactiveskill_3 = false;
            stat.shift_isactiveskill_4 = true;
        }

    }
    public void tooltip_zero()
    {
        tooltip_.trigger = 0;
    }
    public void tooltip_1()
    {
        tooltip_.trigger = 1;
    }
    public void tooltip_2()
    {
        tooltip_.trigger = 2;
    }
    public void tooltip_3()
    {
        tooltip_.trigger = 3;
    }
    public void tooltip_4()
    {
        tooltip_.trigger = 4;
    }

}
