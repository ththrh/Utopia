using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltip_manager : MonoBehaviour
{
    public Text tooltip;
    GameManager gameManager;
    public int trigger;

    // Start is called before the first frame update
    void Start()
    {

        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        tooltip.text = check_tooltip(trigger);
    }
    string check_tooltip(int a)
    {
        string tool;

        switch(a)
        {
            case 0:
                tool = ("");
                return tool;
            case 1:
                tool = ("자연의 힘을 흡수해 HP를 일정량 회복한다.");
                return tool;
            case 2:
                tool = ("그림자 속으로 몸을 숨겨 적에게 발각되지 않는다.");
                return tool;
            case 3:
                tool = ("투사체를 막아주는 결계를 설치한다.");
                return tool;
            case 4:
                tool = ("잠시동안 어떤 피해도 받지 않는다.");
                return tool;
            case 5:
                tool = ("폭발하는 화살을 전방으로 발사한다.");
                return tool;
            case 6:
                tool = ("강력한 폭발을 일으키는 폭탄을 제자리에 내려 놓는다.");
                return tool;
            case 7:
                tool = ("신성한 힘을 폭발시켜 근처의 넓은 지역에 피해를 입힌다.");
                return tool;
            case 8:
                tool = ("마법의 화살을 빠른 속도로 연사한다.");
                return tool;
            case 9:
                tool = ("자연의 에너지를 흡수하여 마나로 변환한다.");
                return tool;
            case 10:
                tool = ("용의 피를 각성시켜 강한 힘을 얻는다.");
                return tool;
            case 11:
                tool = ("바람의 룬을 작동시켜 빠른 속도로 이동한다.");
                return tool;
            case 12:
                tool = ("대지모신의 힘으로 상처를 천천히 치유시킨다.");
                return tool;
        }
        return ("");
        /*
        if (a == 0)
        {
            tool = ("툴팁 없음");
            return tool;
        }

        else if (a == 1)
        {
            tool = ("스킬 1");
            return tool;
        }
        else if (a == 2)
        {
            tool = ("스킬 2");
            return tool;
        }

        else if (a == 3)
        {
            tool = ("스킬 3");
            return tool;
        }
        else if (a == 4)
        {
            tool = ("스킬 4");
            return tool;
        }
        return ("툴팁 없음");

        */

    }
}
