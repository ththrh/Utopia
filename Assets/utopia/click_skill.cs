using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_skill : MonoBehaviour
{
    public Status stat;
    public tooltip_manager tooltip_;

    public GameObject learn_mark_1;
    public GameObject learn_mark_2;
    public GameObject learn_mark_3;
    public GameObject learn_mark_4;

    public void Learn_click_Skill_1()
    {
        if (!stat.click_islearnskill_1)


        {
            if (stat.SkillPoint > 0)
            {
                stat.click_islearnskill_1 = true;
                stat.click_isactiveskill_1 = true;
                stat.click_isactiveskill_2 = false;
                stat.click_isactiveskill_3 = false;
                stat.click_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_1.SetActive(true);
            }
        }
        else if (stat.click_islearnskill_1)
        {
            stat.click_isactiveskill_1 = true;
            stat.click_isactiveskill_2 = false;
            stat.click_isactiveskill_3 = false;
            stat.click_isactiveskill_4 = false;
        }
        else
            return;
    }

    public void Learn_click_Skill_2()
    {
        if (!stat.click_islearnskill_2)


        {
            if (stat.SkillPoint > 0)
            {
                stat.click_islearnskill_2 = true;
                stat.click_isactiveskill_1 = false;
                stat.click_isactiveskill_2 = true;
                stat.click_isactiveskill_3 = false;
                stat.click_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_2.SetActive(true);
            }
        }
        else if (stat.click_islearnskill_2)
        {
            stat.click_isactiveskill_1 = false;
            stat.click_isactiveskill_2 = true;
            stat.click_isactiveskill_3 = false;
            stat.click_isactiveskill_4 = false;
        }
        else
            return;
    }
    public void Learn_click_Skill_3()
    {
        if (!stat.click_islearnskill_3)


        {
            if (stat.SkillPoint > 0)
            {
                stat.click_islearnskill_3 = true;
                stat.click_isactiveskill_1 = false;
                stat.click_isactiveskill_2 = false;
                stat.click_isactiveskill_3 = true;
                stat.click_isactiveskill_4 = false;
                stat.SkillPoint -= 1;

                learn_mark_3.SetActive(true);
            }
        }
        else if (stat.click_islearnskill_3)
        {
            stat.click_isactiveskill_1 = false;
            stat.click_isactiveskill_2 = false;
            stat.click_isactiveskill_3 = true;
            stat.click_isactiveskill_4 = false;
        }
        else
            return;
    }
    public void Learn_click_Skill_4()
    {
        if (!stat.click_islearnskill_4)


        {
            if (stat.SkillPoint > 0)
            {
                stat.click_islearnskill_4 = true;
                stat.click_isactiveskill_1 = false;
                stat.click_isactiveskill_2 = false;
                stat.click_isactiveskill_3 = false;
                stat.click_isactiveskill_4 = true;
                stat.SkillPoint -= 1;

                learn_mark_4.SetActive(true);
            }
        }
        else if (stat.click_islearnskill_4)
        {
            stat.click_isactiveskill_1 = false;
            stat.click_isactiveskill_2 = false;
            stat.click_isactiveskill_3 = false;
            stat.click_isactiveskill_4 = true;
        }
        else
            return;
    }

    public void tooltip_zero()
    {
        tooltip_.trigger = 0;
    }
    public void tooltip_5()
    {
        tooltip_.trigger = 5;
    }
    public void tooltip_6()
    {
        tooltip_.trigger = 6;
    }
    public void tooltip_7()
    {
        tooltip_.trigger = 7;
    }
    public void tooltip_8()
    {
        tooltip_.trigger = 8;
    }
}
