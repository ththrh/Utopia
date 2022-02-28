using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{


    public GameObject player;

    void start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

        player = GameObject.Find("TestPlayer");
        this.transform.SetParent(player.transform, false);
        Destroy(gameObject, 2);
    }

}
