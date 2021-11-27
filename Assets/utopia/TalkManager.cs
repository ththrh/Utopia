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
        talkData.Add(200, new string[] { "나는 촌장이네", "우리 마을에 온 것을 환영하네" });
        talkData.Add(300, new string[] { "바람이...부는 군...", "춥다..." });
        talkData.Add(400, new string[] { "어둡다..." });




        talkData.Add(10 + 200, new string[] { "처음보는 사람이로군", "마을사람들을 만나보겠나?", "사무라이부터 만나고 오게" });
        talkData.Add(11 + 300, new string[] { "촌장이 보냈다고?", "반갑군", "흑마법사를 만나보는게 어때?" });
        talkData.Add(12 + 200, new string[] { "아직 마을 사람들을 다 만나지 못 한 모양이군", "흑마법사는 남쪽에 있다네" });
        talkData.Add(12 + 400, new string[] { "신비한 힘이 느껴지는 사람이군", "촌장이 당신에게 시킬 일이 있는 모양이야","어서 가봐" });

        talkData.Add(20 + 200, new string[] { "최근 마을 앞에 던전이 생겨서 걱정이야.","자네가 해결해 준다고? 정말인가?","흑마법사가 던전의 위치를 아네" });
        talkData.Add(21 + 400, new string[] { "던전은 동쪽에 있어.", "죽지 않기를 빌지" ,"일이 끝나면 촌장에게 가봐"});
        talkData.Add(22 + 200, new string[] { "정말로 고맙네.", "당신은 우리 마을의 영웅이야." });



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
