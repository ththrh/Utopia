using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstermove : MonoBehaviour
{

    public float speed = 1f;
    Vector3 movement;
    int movementflag = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeMovement");

    }

    IEnumerator ChangeMovement()
    {
        movementflag = Random.Range(0, 4);

        yield return new WaitForSeconds(3f);

        StartCoroutine("ChangeMovement");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        Vector3 movevelo = Vector3.zero;

        if(movementflag==1)
        {
            movevelo = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(movementflag == 2)
        {
            movevelo = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movementflag == 3)
        {
            movevelo = Vector3.up;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movementflag == 4)
        {
            movevelo = Vector3.forward;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.position += movevelo * speed * Time.deltaTime;
    }
}
