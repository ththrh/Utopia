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




        talkData.Add(0+400, new string[] { "이 마을은 평화로워 보이지만 기운이 이상해","무슨 일이 있는건가?","저 앞에 사람에게 물어봐야겠군" });
        talkData.Add(10 + 200, new string[] { "처음보는 사람이로군", "마을사람들을 만나보겠나?", "사무라이부터 만나고 오게" });
        talkData.Add(11 + 300, new string[] { "촌장이 보냈다고?", "반갑군", "흑마법사를 만나보는게 어때?" });
        talkData.Add(12 + 200, new string[] { "아직 마을 사람들을 다 만나지 못 한 모양이군", "흑마법사는 남쪽에 있다네" });
        talkData.Add(12 + 400, new string[] { "신비한 힘이 느껴지는 사람이군", "마을에 온 것을 환영하네", "촌장에게 돌아가보자" });

        talkData.Add(20 + 200, new string[] { "흑마법사가 돼지때문에 골머리라더군","자네가 해결해 준다고? 정말인가?","흑마법사에게 가보게" });
        talkData.Add(21 + 400, new string[] { "성난 돼지들이 길을 막고 있지" ,"무운을 빈다네"});
        talkData.Add(22 + 400, new string[] { "아직인가?" });
        talkData.Add(23 + 400, new string[] { "돼지들의 상태가 이상하다고?"});

        talkData.Add(30 + 400, new string[] { "흠, 확실히 평소보다 더욱 난폭한거 같구만.", "사무라이는 평소에 사냥을 자주하지","그에게 물어보는게 어떤가?"});
        talkData.Add(31 + 300, new string[] { "뭐? 동물들이 흉폭해져?","벌은 이상징후를 제일 먼저 알아챈다고들 하지","돼지 농장너머 벌 군락지에 다녀와보게나" });
        talkData.Add(32 + 300, new string[] { "벌 군락지는 돼지 농장 너머에 있어" });
        talkData.Add(33 + 300, new string[] { "벌들 까지?", "이게 대체 무슨일이지?" });

        talkData.Add(40 + 300, new string[] { "이건 평범한 사건이 아니야","아무래도 마법이 관련된거 같아. 흑마법사에게 물어봐야겠어" });
        talkData.Add(41 + 400, new string[] { "마법?", "일리가 있는 말이야", "촌장에게 이 사실을 알리고 사건을 해결해야겠어" });
        talkData.Add(42 + 200, new string[] { "아, 자네구만 때 맞추어 와줬구만","마법? 어쩐지...","지금 포악해진 늑대들이 농장을 공격하고 있다네","그 녀석들을 처리해 줄 수 있겠나?" });
        talkData.Add(43 + 200, new string[] { "이게 대체 무슨 일일꼬..." });
        talkData.Add(44 + 200, new string[] { "정말 감사하네.","그런데 마을 정찰대에게서 안 좋은 소식이 들려왔다네" });

        talkData.Add(50 + 200, new string[] { "거대한 마법을 쓰는 곰이 나타났다는 소식이야","녀석을 헤치우지 못하면 우리 마을으 끝장일세","염치없지만...처리를 부탁해도 되겠나?" });
        talkData.Add(51 + 200, new string[] { "신이시여 우리 마을을 구원하소서..."});
        talkData.Add(52 + 200, new string[] { "정말인가?","정말 대단하군! 우리 마을은 자네를 영웅으로 기억할 것이야!" });


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
