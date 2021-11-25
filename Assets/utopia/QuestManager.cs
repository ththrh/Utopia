using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    public int questid;
    public int questActionIndex;
    public GameObject[] gameObjects;
    

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
        questlist.Add(10, new QuestData("나무의 부탁", new int[] { 1000,2000}));
        questlist.Add(20, new QuestData("팔 찾아주기", new int[] { 5000, 2000 }));
        questlist.Add(30, new QuestData("엔드퀘스트", new int[] { 0 }));

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
            

        controlobj();



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

    }

    void controlobj()
    {
        switch(questid)
        {
            case 10:
                if (questActionIndex == 2)
                    gameObjects[0].SetActive(true);
                break;
            case 20:
                if (questActionIndex == 1)
                    gameObjects[0].SetActive(false);
                break;
        }
    }
}
