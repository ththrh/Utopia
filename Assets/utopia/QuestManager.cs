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

    Dictionary<int, QuestData> questlist;
    // Start is called before the first frame update
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
        questlist.Add(50, new QuestData("거대 곰 처치하기", new int[] { 200, 9999, 200 }));
        questlist.Add(60, new QuestData("엔드퀘스트", new int[] { 0 }));

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
        }
        if(questid == 20)
            if (questActionIndex == 2)
                if (pig_death_count == 5)
                    questActionIndex++;
        if (questid == 30)
            if (questActionIndex == 2)
                if (bee_death_count == 8)
                    questActionIndex++;
        if (questid == 40)
            if (questActionIndex == 3)
                 if (wolf_death_count == 9)
                      questActionIndex++;
        if (questid == 50)
            if (questActionIndex == 1)
                 if (wolf_death_count == 9)
                    questActionIndex++;



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
                break;
            case 30:
                Debug.Log("보상2");
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
}
