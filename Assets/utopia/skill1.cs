using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill1 : MonoBehaviour
{


    public GameObject click_skill_panel;
    public GameObject shift_skill_panel;
    public GameObject q_skill_panel;

    public Text sptxt;

    public Status stat;

    public void Start()
    {

    }

    public void Update()
    {

        sptxt.text = "남은 스킬 포인트 :"+ stat.SkillPoint.ToString();
    }


    // Start is called before the first frame update



    public void click_Skill_Panel_On()
    {
            click_skill_panel.SetActive(true);
            shift_skill_panel.SetActive(false);
            q_skill_panel.SetActive(false);
    }

    public void shift_Skill_Panel_On()
    {

            click_skill_panel.SetActive(false);
            shift_skill_panel.SetActive(true);
            q_skill_panel.SetActive(false);

    }
    public void q_Skill_Panel_On()
    {

            click_skill_panel.SetActive(false);
            shift_skill_panel.SetActive(false);
            q_skill_panel.SetActive(true);
    }




}
