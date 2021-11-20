using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObj;
    public bool isAction;
    public int talkindex;
    public void Action(GameObject scanobj)
    {

        scanObj = scanobj;
        ObjData objdata = scanObj.GetComponent<ObjData>();
        Talk(objdata.id, objdata.isNpc);

        talkPanel.SetActive(isAction);
}

    void Talk(int id, bool isNpc)
    {
        string talkdata = talkManager.GetTalk(id, talkindex);

        if(talkdata == null)
        {
            isAction = false;
            talkindex = 0;
            return;
        }
        if(isNpc)
        {
            talkText.text = talkdata;
        }
        else 
        {
            talkText.text = talkdata;
        }

        isAction = true;
        talkindex++;

    }


    void Update()
    {
        
    }
}
