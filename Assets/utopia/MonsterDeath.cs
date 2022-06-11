using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public int HP=3;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            StartCoroutine(alphablink());
            Destroy(gameObject);
            

        }
    }
    IEnumerator alphablink()
    {
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1, 1, 1, 0.8f);

        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1, 1, 1, 0.6f);

        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1, 1, 1, 0.4f);

        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1, 1, 1, 0.2f);

        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1, 1, 1, 0);

    }
}

