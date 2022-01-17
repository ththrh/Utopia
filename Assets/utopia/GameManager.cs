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


    void Start()
    {
        GameLoad();
        questtalk.text = QuestManager.checkquest();
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
