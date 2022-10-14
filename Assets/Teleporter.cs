using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public bool stageActivate = false;
    public GameObject Stage;
    public Transform GetDestination()
    {
        return destination;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("ExitTeleporter"))
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("activate");
                Stage.SetActive(true);
            }
        }
    }
}
