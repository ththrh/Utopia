using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooltimer_shift : MonoBehaviour
{
    public Text cooltimertxt;
    public MOVE move;
    public Status stat;

    
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(stat.shift_isactiveskill_1)
        {
            if(move.heal_cooltimer >= 10)
            {
                cooltimertxt.text = ("");
            }
            else
                cooltimertxt.text = (move.heal_cooltimer.ToString("F0"));
        }
        else if (stat.shift_isactiveskill_2)
        {
            if (move.darksight_cooltimer >= 6)
            {
                cooltimertxt.text = ("");
            }
            else
                cooltimertxt.text = (move.darksight_cooltimer.ToString("F0"));
        }
        else if (stat.shift_isactiveskill_3)
        {
            if (move.wall_cooltimer >= 15)
            {
                cooltimertxt.text = ("");
            }
            else
                cooltimertxt.text = (move.wall_cooltimer.ToString("F0"));
        }
        else if (stat.shift_isactiveskill_4)
        {
            if (move.shield_cooltimer >= 8)
            {
                cooltimertxt.text = ("");
            }
            else
                cooltimertxt.text = (move.shield_cooltimer.ToString("F0"));
        }
        else
        {
            cooltimertxt.text = ("");
        }
    }
}
