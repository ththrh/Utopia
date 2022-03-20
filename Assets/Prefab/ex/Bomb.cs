using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("explose");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator explose()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(explosion,transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
