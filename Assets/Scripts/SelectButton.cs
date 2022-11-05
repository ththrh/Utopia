using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    public Button[] buttons;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v=Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Vertical"))
        {
            if(v == 1)
            {
                index = index > 0 ? index - 1 : index;
            }
            if (v == -1)
            {
                index = index < buttons.Length - 1 ? index + 1 : index;
            }
        }
        if (Input.GetButtonDown("Interaction"))
        {
            
        }
    }
}
