using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_image_manager : MonoBehaviour
{

    public Sprite[] click_SkillImage;
    Dictionary<int, Sprite> click_skilldata;

    public Sprite[] q_SkillImage;
    Dictionary<int, Sprite> q_skilldata;

    public Sprite[] shift_SkillImage;
    Dictionary<int, Sprite> shift_skilldata;


    void Awake()
    {
        click_skilldata = new Dictionary<int, Sprite>();
        click_makedata();

        q_skilldata = new Dictionary<int, Sprite>();
        q_makedata();

        shift_skilldata = new Dictionary<int, Sprite>();
        shift_makedata();
    }
    // Start is called before the first frame update
    void click_makedata()
    {
        click_skilldata.Add(0, click_SkillImage[0]);
        click_skilldata.Add(1, click_SkillImage[1]);
        click_skilldata.Add(2, click_SkillImage[2]);
        click_skilldata.Add(3, click_SkillImage[3]);
        click_skilldata.Add(4, click_SkillImage[4]);

    }

    void q_makedata()
    {
        q_skilldata.Add(0, q_SkillImage[0]);
        q_skilldata.Add(1, q_SkillImage[1]);
        q_skilldata.Add(2, q_SkillImage[2]);
        q_skilldata.Add(3, q_SkillImage[3]);
        q_skilldata.Add(4, q_SkillImage[4]);

    }

    void shift_makedata()
    {
        shift_skilldata.Add(0, shift_SkillImage[0]);
        shift_skilldata.Add(1, shift_SkillImage[1]);
        shift_skilldata.Add(2, shift_SkillImage[2]);
        shift_skilldata.Add(3, shift_SkillImage[3]);
        shift_skilldata.Add(4, shift_SkillImage[4]);

    }

    public Sprite click_Getskillimage(int skillIndex)
    {
        return click_skilldata[skillIndex];
    }
    public Sprite q_Getskillimage(int skillIndex)
    {
        return q_skilldata[skillIndex];
    }
    public Sprite shift_Getskillimage(int skillIndex)
    {
        return shift_skilldata[skillIndex];
    }
}
