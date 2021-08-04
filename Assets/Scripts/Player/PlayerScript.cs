using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //View Direction
        Vector2 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 oPos = transform.position;
        float xDif = mPos.x - oPos.x;
        float yDif = mPos.y - oPos.y;
        float xDifAbs = Mathf.Abs(xDif);
        float yDifAbs = Mathf.Abs(yDif);
        if (xDif < 0 && xDifAbs >= yDifAbs)
        {
            anim.SetInteger("ViewDir", 2);
            transform.localScale = new Vector3(-5, 5, 1);
        }
        else if(xDif >= 0 && xDifAbs >= yDifAbs)
        {
            anim.SetInteger("ViewDir", 2);
            transform.localScale = new Vector3(5, 5, 1);
        }
        else if(yDif < 0 && xDifAbs < yDifAbs)
        {
            anim.SetInteger("ViewDir", 0);
        }
        else if(yDif >=0 && xDifAbs < yDifAbs)
        {
            anim.SetInteger("ViewDir", 1);
        }
        //Move
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            anim.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            anim.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            anim.SetTrigger("Walk");
        }
    }
}
