using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monstermove2 : MonoBehaviour
{

    public float speed = 1f;
    Vector3 movement;
    int movementflag = 0;
    public string dist = "";
    public Transform target;
    NavMeshAgent nav;

    public bool isTracing = false;
    public GameObject traceTarget;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeMovement");
        nav = GetComponent<NavMeshAgent>();
    }

    IEnumerator ChangeMovement()
    {
        movementflag = Random.Range(0, 4);

        yield return new WaitForSeconds(2f);

        StartCoroutine("ChangeMovement");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(!isTracing)
            move();
    }


    void OnTriggerEnter2D (Collider2D other)
    {

        if(other.tag=="Player")
        {
            traceTarget = other.gameObject;
            

            StopCoroutine("ChangeMovement");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            isTracing = true;
            nav.SetDestination(traceTarget.transform.position);

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            isTracing = false;
            StartCoroutine("ChangeMovement");

        }

    }


    void move()
    {
        Vector3 movevelo = Vector3.zero;



        

        if (movementflag == 0)
                dist = "left";
        else if (movementflag == 1)
                dist = "right";
        else if (movementflag == 2)
                dist = "up";
        else if (movementflag == 3)
                dist = "down";


        if (dist=="left")
        {
            movevelo = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (dist == "right")
        {
            movevelo = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (dist == "up")
        {
            movevelo = Vector3.up;

        }
        else if (dist == "down")
        {
            movevelo = Vector3.forward;

        }
        transform.position += movevelo * speed * Time.deltaTime;
    }
}

