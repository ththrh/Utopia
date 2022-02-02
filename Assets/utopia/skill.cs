using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    public Status stat;
    public Sprite[] SkillImage;
    Dictionary<int, Sprite> skilldata;

    // Start is called before the first frame update
    void Awake()
    {
        skilldata = new Dictionary<int, Sprite>();
        makedata();
    }
    void makedata()
    {
        skilldata.Add(0,SkillImage[0]);
        skilldata.Add(1,SkillImage[1]);
        skilldata.Add(2,SkillImage[2]);
        skilldata.Add(3, SkillImage[3]);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void LearnSkill_1()
    {
        if (stat.SkillPoint > 0)
        {
            if (!stat.islearnskill_1 && !stat.islearnskill_2 && !stat.islearnskill_3)
            {
                stat.islearnskill_1 = true;
                stat.SkillPoint -= 1;
            }

            else
                return;
        }
        else
            return;
    }
    public void LearnSkill_2()
    {
        if (stat.SkillPoint > 0)
        {
            if (stat.islearnskill_1 && !stat.islearnskill_2 && !stat.islearnskill_3)
            {
                stat.islearnskill_2 = true;
                stat.islearnskill_1 = false;
                stat.SkillPoint -= 1;
            }
            else
                return;
        }
        else
            return;

    }
    public void LearnSkill_3()
    {
        if(stat.SkillPoint>0)
        {
            if (!stat.islearnskill_1 && stat.islearnskill_2 && !stat.islearnskill_3)
            {
                stat.islearnskill_2 = false;
                stat.islearnskill_3 = true;
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
        return skilldata[skillIndex];
    }
}
