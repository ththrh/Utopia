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
        talkData.Add(2000, new string[] { "팔이 아파."});



        talkData.Add(10 + 1000, new string[] { "처음보는 사람이로군", "왼쪽에 팔 없는 사람을 만나고 와주게" });
        talkData.Add(11 + 2000, new string[] { "나무가 보내서 왔다고?", "내 팔을 찾아줬으면 해" });

        talkData.Add(20 + 1000, new string[] { "팔을 찾아달라고 했다고?", "머리도 없는 놈이?" });
        talkData.Add(20 + 2000, new string[] { "팔이 아프다고"});
        talkData.Add(20 + 5000, new string[] { "팔이다." });

        talkData.Add(21 + 2000, new string[] { "와우 고마워" });
    }

    public string GetTalk(int id, int talkIndex)  //토크의 순서 index
    {
        if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);
            else
                return GetTalk(id - id % 10, talkIndex);
        }

        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];



    }
}
