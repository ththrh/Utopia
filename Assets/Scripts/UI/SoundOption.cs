using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOption : MonoBehaviour
{
    public GameObject Menu;
    public GameObject SoundOpt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenOption()
    {
        if (Menu.activeSelf)
        {
            Menu.SetActive(false);
            SoundOpt.SetActive(true);
        }
        else
        {
            Menu.SetActive(true);
            SoundOpt.SetActive(false);
        }
    }
}
