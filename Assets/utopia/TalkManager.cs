using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
        
    }

    // Update is called once per frame
    void GenerateData()
    {
        talkData.Add(100, new string[] { "이건 그냥 나무다.","말을 하지 않아서 다행이다." });
        talkData.Add(1000, new string[] { "나는 나무의 정령이다.", "썩 이곳에서 나가거라" });

    }

    public string GetTalk(int id, int talkIndex)  //토크의 순서 index
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];


    }
}
