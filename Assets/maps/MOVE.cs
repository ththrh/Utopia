using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Dir
{
    public const int up = 1;
    public const int down = 2;
    public const int left = 3;
    public const int right = 4;
}

public class MOVE : MonoBehaviour
{

    Vector3 dirVec;
    GameObject scanobj;
    public GameManager manager;

    float Speed;
    float Speed2;
    public float timer = 0.5f;

    public bool isAttack = false;
    public bool isDash = false;
    public float atktimer = 0.7f;
    public int dir = 2;
    Rigidbody2D rigid;
    float h;
    float v;
    Animator anim;
    SpriteRenderer rend;
    Status stat;

    public float shield_cooltimer = 8;
    public GameObject shield;
    public bool isshield = false;

    public float darksight_cooltimer = 6;
    public bool isdarksight = false;
    SpriteRenderer sprite;

    public float heal_cooltimer = 10;
    bool isheal = false;

    public float wall_cooltimer = 15;
    bool iswall = false;
    public GameObject wall;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        stat = GetComponent<Status>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed = stat.speed;
        Speed2 = stat.dash;
        if (!isDash && !manager.isAction)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
            transform.Translate(new Vector3(h, v, 0) * Speed * Time.deltaTime) ;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }


        if(Input.GetKeyDown(KeyCode.D))
        {
            dirVec = Vector3.right;
            dir = Dir.right;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            dirVec = Vector3.left;
            dir = Dir.left;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            dirVec = Vector3.up;
            dir = Dir.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            dirVec = Vector3.down;
            dir = Dir.down;
        }
        //대쉬
        if (Input.GetKeyDown(KeyCode.Space) && !isAttack && stat.Stamina > 0)
        {
            if (!isDash && timer == 0.5f)
            {
                stat.Stamina -= 1;
                isDash = true;
            }
        }
        if (isDash)
        {
            transform.Translate(new Vector3(h * Speed2, v * Speed2, 0) * Time.deltaTime);
        }
        if (isDash && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = 0.5f;
            isDash = false;
        }

        if ((Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1)) && !manager.isAction && !isAttack)
        {
            isAttack = true;
        }
        if (isAttack)
        {
            atktimer -= Time.deltaTime;
            if (atktimer <= 0)
            {
                isAttack = false;
                atktimer = 0.7f;
            }
        }

        if(Input.GetKeyDown(KeyCode.E)&&scanobj!=null)
        {
            manager.Action(scanobj);
        }

        //김민우스킬test
        if (Input.GetMouseButtonDown(1))
        {
            if (stat.click_islearnskill_1)
                Debug.Log("클릭 스킬사용1");
            else if (stat.click_islearnskill_2)
                Debug.Log("클릭 스킬사용2");
            else if (stat.click_islearnskill_3)
                Debug.Log("클릭 스킬사용3");
            else if (stat.click_islearnskill_4)
                Debug.Log("클릭 스킬사용4");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (stat.shift_isactiveskill_1)
            {
                if(heal_cooltimer == 10)
                {
                    isheal = true;
                    stat.hp += 3;
                    Debug.Log("쉬프트 스킬사용1");
                }
                else
                    Debug.Log("쉬프트 쿨타임1");

            }

            else if (stat.shift_isactiveskill_2)
            {
                if (darksight_cooltimer == 6)
                {
                    isdarksight = true;
                    Debug.Log("쉬프트 스킬사용2");
                }
                else
                    Debug.Log("쉬프트 쿨타임2");
  
            }

            else if (stat.shift_isactiveskill_3)
            {
                GameObject player = GameObject.Find("TestPlayer");
                Vector2 vec = new Vector2(player.transform.position.x , player.transform.position.y);
                if (wall_cooltimer == 15)
                {
                    iswall = true;
                    if (dir == Dir.left || dir == Dir.right)
                    {
                        Instantiate(wall, player.transform.position, Quaternion.identity);
                    }
                    else
                        
                        Instantiate(wall, vec, Quaternion.Euler(0, 0, 90));
                    Debug.Log("쉬프트 스킬사용3");
                }
                else
                    Debug.Log("쉬프트3 쿨타임");
            }
   
            else if (stat.shift_isactiveskill_4)
            {
                if (shield_cooltimer == 8)
                {
                    isshield = true;
                    Instantiate(shield);
                    Debug.Log("쉬프트 스킬사용4");
                }
                else
                    Debug.Log("쉬프트4 쿨타임");
            }
        

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (stat.q_islearnskill_1)
                Debug.Log("큐 스킬사용1");
            else if (stat.q_islearnskill_2)
                Debug.Log("큐 스킬사용2");
            else if (stat.q_islearnskill_3)
                Debug.Log("큐 스킬사용3");
            else if (stat.q_islearnskill_4)
                Debug.Log("큐 스킬사용4");
        }

        if (isshield)
        {
            shield_cooltimer -= Time.deltaTime;
            if (shield_cooltimer < 0)
            {
                isshield = false;
                shield_cooltimer = 8;
            }
        }

        if(isdarksight)
        {
            darksight_cooltimer -= Time.deltaTime;
            sprite.color = new Color(1, 1, 1, 0.5f);
            if(darksight_cooltimer < 3)
            {
                sprite.color = new Color(1, 1, 1, 1);
            }
            if(darksight_cooltimer<0)
            {
                isdarksight = false;
                darksight_cooltimer = 6;
            }
           
        }
        if(isheal)
        {
            heal_cooltimer -= Time.deltaTime;
            if(heal_cooltimer<0)
            {
                isheal = false;
                heal_cooltimer = 10;
            }
        }
        if (iswall)
        {
            wall_cooltimer -= Time.deltaTime;
            if (wall_cooltimer < 0)
            {

                iswall = false;
                wall_cooltimer = 15;
            }
        }

    }


    

    void FixedUpdate()
    {
        
        Vector2 NEWV = new Vector2(rigid.position.x, rigid.position.y + 0.5f);
        Debug.DrawRay(NEWV, dirVec * 1f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(NEWV, dirVec, 1.5f,LayerMask.GetMask("obj" ));

        if (rayHit.collider != null)
        {
            scanobj = rayHit.collider.gameObject;
        }
        else
            scanobj = null;

    }


}
