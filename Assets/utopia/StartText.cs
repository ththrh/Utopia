using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public Text text;
    int a = 0;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextStartUI()
    {
        a = a + 1;
        if (a == 1)
        {
            text.text = ("K키를 눌러 나타난 스킬들을 클릭하면 스킬을 배울 수 있습니다. 배운 스킬들은 SHIFT,Q,우클릭 버튼을 통해 사용할 수 있습니다. 마력이 없다면 좌클릭을 통해 기본적인 공격을 할 수도 있습니다.");
            
        }

        else if (a == 2)
        {
            gameObject.SetActive(false);
            text.text = ("흑마법사에게 돌아가자");
        }
        else if (a == 3)
        {
            gameObject.SetActive(false);
            text.text = ("사무라이에게 돌아가자");
        }
        else if (a == 4)
        {
            gameObject.SetActive(false);
            text.text = ("촌장에게 돌아가자");
        }
        else if (a == 5)
        {
            gameObject.SetActive(false);
            text.text = ("촌장에게 돌아가자");
        }
        else if (a == 6)
        {
            gameObject.SetActive(false);
            text.text = ("촌장에게 돌아가자");
        }

    }
}
