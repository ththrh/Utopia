using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEx : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject, 0.66f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
