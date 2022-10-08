using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    private EnemyHP enemyHP;

    [SerializeField]
    private GameObject gunpoint1;
    [SerializeField]
    private GameObject gunpoint2;
    [SerializeField]
    private GameObject gunpoint3;


    private void Awake() 
    {
        enemyHP = GetComponent<EnemyHP>();
    }

    private void Start()
    {
        StartCoroutine("attackPattern");
    }

    private void Update()
    {


    }

    IEnumerator  attackPattern()
    {
        while(true)
        {
            int result = Random.Range(1,4);
            if(result == 1)
            {
                gunpoint1.SetActive(true);
                gunpoint2.SetActive(false);
                gunpoint3.SetActive(false);
            }
            else if(result == 2)
            {
                gunpoint1.SetActive(false);
                gunpoint2.SetActive(true);
                gunpoint3.SetActive(false);
            }
            else if(result == 3)
            {
                gunpoint1.SetActive(false);
                gunpoint2.SetActive(false);
                gunpoint3.SetActive(true);
            }

            yield return new WaitForSeconds(5.0f);
        }
    }
    
    
}