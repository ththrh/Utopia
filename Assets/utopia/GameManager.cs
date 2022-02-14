using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager QuestManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObj;
    public bool isAction;
    public int talkindex;
    public GameObject menuset;
    public Text questtalk;
    public GameObject Player;

    public GameObject skillpanel;

    public skill1 skill;
    public Status stat;


    public click_skill click_Skill;
    public shift_skill shift_Skill;
    public q_skill q_Skill;

    public int click_skillname;
    public int shift_skillname;
    public int q_skillname;

    public Image click_skillimage;
    public Image shift_skillimage;
    public Image q_skillimage;
    void Start()
    {
        click_skillname = 0;
        shift_skillname = 0;
        q_skillname = 0;
        GameLoad();
        questtalk.text = QuestManager.checkquest();

 
    }

    void Awake()
    {

    }
    public void Action(GameObject scanobj)
    {

        scanObj = scanobj;
        ObjData objdata = scanObj.GetComponent<ObjData>();
        Talk(objdata.id, objdata.isNpc);

        talkPanel.SetActive(isAction);
}

    void Talk(int id, bool isNpc)
    {
        int questTalkIndex = QuestManager.GetQuestTalkIndex(id);
        string talkdata = talkManager.GetTalk(id+ questTalkIndex, talkindex);

        if(talkdata == null)
        {
            isAction = false;
            talkindex = 0;
            questtalk.text = QuestManager.checkquest(id);
            return;
        }
        if(isNpc)
        {
            talkText.text = talkdata;
        }
        else 
        {
            talkText.text = talkdata;
        }

        isAction = true;
        talkindex++;

    }


    void Update()
    {

        if (Input.GetButtonDown("Cancel"))
        {
            if (menuset.activeSelf)
                menuset.SetActive(false);
            else
                menuset.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (skillpanel.activeSelf)
                skillpanel.SetActive(false);
            else
                skillpanel.SetActive(true);
        }
        if (!stat.click_islearnskill_1 && !stat.click_islearnskill_2 && !stat.click_islearnskill_3 && !stat.click_islearnskill_4)
        {
            click_skillname = 0;
        }
        else if (stat.click_islearnskill_1)
        {
            click_skillname = 1;
        }
        else if (stat.click_islearnskill_2)
        {
            click_skillname = 2;
        }
        else if (stat.click_islearnskill_3)
        {
            click_skillname = 3;
        }
        else if (stat.click_islearnskill_4)
        {
            click_skillname = 4;
        }
        else
            return;

        if (!stat.shift_islearnskill_1 && !stat.shift_islearnskill_2 && !stat.shift_islearnskill_3 && !stat.shift_islearnskill_4)
        {
            shift_skillname = 0;
        }
        else if (stat.shift_islearnskill_1)
        {
            shift_skillname = 1;
        }
        else if (stat.shift_islearnskill_2)
        {
            shift_skillname = 2;
        }
        else if (stat.shift_islearnskill_3)
        {
            shift_skillname = 3;
        }
        else if (stat.shift_islearnskill_4)
        {
            shift_skillname = 4;
        }
        else
            return;

        if (!stat.q_islearnskill_1 && !stat.q_islearnskill_2 && !stat.q_islearnskill_3 && !stat.q_islearnskill_4)
        {
            q_skillname = 0;
        }
        else if (stat.q_islearnskill_1)
        {
            q_skillname = 1;
        }
        else if (stat.q_islearnskill_2)
        {
            q_skillname = 2;
        }
        else if (stat.q_islearnskill_3)
        {
            q_skillname = 3;
        }
        else if (stat.q_islearnskill_4)
        {
            q_skillname = 4;
        }
        else
            return;
        skillport(click_skillname, shift_skillname, q_skillname);


    }
    void skillport(int click_skillindex, int shift_skillinedx, int q_skillindex)
    {
        click_skillimage.sprite = click_Skill.Getskillimage(click_skillindex);
        shift_skillimage.sprite = shift_Skill.Getskillimage(shift_skillinedx);
        q_skillimage.sprite = q_Skill.Getskillimage(q_skillindex);
    }


    public void GameSave()
    {
        PlayerPrefs.SetFloat("PlayerX",Player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY",Player.transform.position.y);
        PlayerPrefs.SetInt("QuestID", QuestManager.questid);
        PlayerPrefs.SetInt("QuestActionIndex", QuestManager.questActionIndex);
        PlayerPrefs.Save();

        menuset.SetActive(false);
    }
    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("PlayerX"))
            return;
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");
        int questID = PlayerPrefs.GetInt("QuestID");
        int questactionindex = PlayerPrefs.GetInt("QuestActionIndex");

        Player.transform.position = new Vector3(x, y, 0);
        QuestManager.questid = questID;
        QuestManager.questActionIndex = questactionindex;
        QuestManager.controlobj();

    }
    public void GameExit()
    {
        Application.Quit();
    }
}
