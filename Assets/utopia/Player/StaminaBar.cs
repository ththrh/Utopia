using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public GameObject player;
    Status playerStatus;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus = player.GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Image>().fillAmount = (float)playerStatus.Stamina / (float)playerStatus.MaxStamina;
    }
}
