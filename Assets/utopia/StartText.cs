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
        if (a == 0)
        {
            text.text = ("K키를 눌러 나타난 스킬들을 클릭하면 스킬을 배울 수 있습니다. 배운 스킬들은 SHIFT,Q,우클릭 버튼을 통해 사용할 수 있습니다. 마력이 없다면 좌클릭을 통해 기본적인 공격을 할 수도 있습니다.");
            a = a + 1;
        }

        else
        {
            Destroy(gameObject);
        }
        
    }
}
