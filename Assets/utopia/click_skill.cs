using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_skill : MonoBehaviour
{
    public Status stat;
    public Sprite[] SkillImage;
    Dictionary<int, Sprite> click_skilldata;

    void Awake()
    {
        click_skilldata = new Dictionary<int, Sprite>();
        makedata();
    }
    void makedata()
    {
        click_skilldata.Add(0, SkillImage[0]);
        click_skilldata.Add(1, SkillImage[1]);
        click_skilldata.Add(2, SkillImage[2]);
        click_skilldata.Add(3, SkillImage[3]);
        click_skilldata.Add(4, SkillImage[4]);

    }
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
            }
        }
        else if (stat.click_islearnskill_3)
        {
            stat.click_isactiveskill_1 = true;
            stat.click_isactiveskill_2 = false;
            stat.click_isactiveskill_3 = false;
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
    public Sprite Getskillimage(int skillIndex)
    {
        return click_skilldata[skillIndex];
    }
}
