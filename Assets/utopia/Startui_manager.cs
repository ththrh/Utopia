using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startui_manager : MonoBehaviour
{
    int flag;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            flag = flag + 1;
            start_ui_next();
        }
        if(flag == 5)
        {
            Destroy(gameObject);
        }
    }
    void start_ui_next()
    {
        switch (flag)
        {


            case 1:
                text.text = ("k를 눌러 스킬창을 i를 눌러 아이템창을 esc키를 눌러 메뉴와 퀘스트를 확인할 수 있습니다.");
                break;
            case 2:
                text.text = ("우클릭으로 공격을 할 수 있으며 Shift,Q,좌클릭 버튼으로 강한 스킬을 발사할 수 있습니다.");
                break;
            case 3:
                text.text = ("스페이스바를 활용해 슬라이딩을 할 수 있습니다.");
                break;
            case 4:
                text.text = ("즐거운 모험되시길 바라겠습니다.");
                break;
        }
    }
}
