using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{

    [SerializeField] Transform[] foodPos;
    [SerializeField] float speed = 5f;
    int foodNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = foodPos[foodNum].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovePath();
    }
    public void MovePath()
    {
        transform.position = Vector2.MoveTowards(transform.position,foodPos[foodNum].transform.position,speed * Time.deltaTime);
    
        if(transform.position == foodPos[foodNum].transform.position)
        {
            foodNum++;
        }
        if(foodNum == foodPos.Length)
        {
            foodNum = 0;
        }
        

    }

}
