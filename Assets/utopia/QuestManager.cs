using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager : MonoBehaviour
{

    public int questid;
    public int questActionIndex;
    public GameObject[] gameObjects;

    public int pig_death_count;
    public int bee_death_count;
    public int wolf_death_count;
    public int bear_death_count;

    public GameObject text;


    [SerializeField]
    GameObject Ltp;
    GameObject Player;

    bool ST1C = false;
    bool ST2C = false;
    bool ST3C = false;
    bool ST4C = false;
    bool ST5C = false;

    [SerializeField]
    GameObject ST1;
    [SerializeField]
    GameObject ST2;
    [SerializeField]
    GameObject ST3;
    [SerializeField]
    GameObject ST4;
    [SerializeField]
    GameObject ST5;
    Dictionary<int, QuestData> questlist;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }
    void Awake()
    {
        questlist = new Dictionary<int, QuestData>();
        makedata();
    }


    // Update is called once per frame
    void makedata()
    {

        questlist.Add(10, new QuestData("마을사람 만나기", new int[] { 200,300,400}));
        questlist.Add(20, new QuestData("마을의 맷돼지 문제", new int[] { 200, 400, 9999, 400 }));
        questlist.Add(30, new QuestData("수상한 야생동물", new int[] { 400, 300, 9999, 300 }));
        questlist.Add(40, new QuestData("사건의 원인을 찾아서", new int[] { 300, 400, 200, 9999, 200 }));
        questlist.Add(50, new QuestData("마물의소굴", new int[] { 200, 9999, 200 }));
        questlist.Add(60, new QuestData("거대 마물 처치하기", new int[] { 200, 9999, 200 }));
        questlist.Add(70, new QuestData("엔드퀘스트", new int[] { 0 }));

    }

    public int GetQuestTalkIndex(int id)
    {
        return questid + questActionIndex;
    }
    public string checkquest(int id)
    {



        if (id == questlist[questid].npcId[questActionIndex])
        {
            questActionIndex++;



            if (questid + questActionIndex == 22)
            {
                ST1.GetComponent<Regeneration>().destroyFence1();
                Debug.Log("삭제함수 호출");
            }
            if (questid + questActionIndex == 32)
            {
                ST1.GetComponent<Regeneration>().destroyFence();
                Debug.Log("삭제함수 호출");
            }
            if (questid + questActionIndex == 43)
            {
                ST2.GetComponent<Regeneration>().destroyFence();
                Debug.Log("삭제함수 호출");
            }
            if (questid + questActionIndex == 51)
            {
                ST3.GetComponent<Regeneration>().destroyFence();
                Debug.Log("삭제함수 호출");
            }
            if (questid + questActionIndex == 61)
            {
                ST4.GetComponent<Regeneration>().destroyFence();
                Debug.Log("삭제함수 호출");
            }
        }


        //controlobj();



        if (questActionIndex == questlist[questid].npcId.Length)
            nextquest();


        return questlist[questid].questName;
    }

    public string checkquest()
    {


        return questlist[questid].questName;
    }

    void nextquest()
    {
        questid += 10;
        questActionIndex = 0;

        switch (questid)
        {
            case 20:
                Debug.Log("보상1");
                Player.GetComponent<Status>().SkillPoint = Player.GetComponent<Status>().SkillPoint+1;
                break;
            case 30:
                Debug.Log("보상2");
                Player.GetComponent<Status>().SkillPoint = Player.GetComponent<Status>().SkillPoint + 1;
                break;
            case 40:
                Debug.Log("보상3");
                Player.GetComponent<Status>().SkillPoint = Player.GetComponent<Status>().SkillPoint + 1;
                break;
            case 50:
                Debug.Log("보상4");
                Player.GetComponent<Status>().SkillPoint = Player.GetComponent<Status>().SkillPoint + 1;
                break;

        }
    }

    public void controlobj()
    {
        switch(questid)
        {
            case 10:
                if (questActionIndex == 2)
                    gameObjects[0].SetActive(true);
                break;
            case 20:
                if (questActionIndex == 0)
                    gameObjects[0].SetActive(true);
                if (questActionIndex == 3)
                    gameObjects[0].SetActive(false);
                break;
        }
    }
    public void compensation()
    {

    }

    public void Killtrigger()
    {
        Debug.Log(ST1.transform.childCount);
        if (ST1.transform.childCount <= 1 && ST1C == false)
        {
            questActionIndex++;
            ST1C = true;
            text.SetActive(true);
        }

        if (ST2.transform.childCount <= 1 && ST2C == false)
        {
            questActionIndex++;
            ST2C = true;
            text.SetActive(true);
        }
        if (ST3.transform.childCount <= 1 && ST3C == false)
        {
            questActionIndex++;
            ST3C = true;
            text.SetActive(true);
        }
        if (ST4.transform.childCount <= 1 && ST4C == false)
        {
            questActionIndex++;
            ST4C = true;
            text.SetActive(true);
        }
        if (ST5.transform.childCount <= 1 && ST5C == false)
        {
            questActionIndex++;
            Ltp.SetActive(true);
            ST5C = true;
        }
    }
}
