using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static public SoundManager instance;
    AudioSource audioSource;

    private void Awake() 
    {
        if (instance == null)  
        {
            instance = this; 
            DontDestroyOnLoad(gameObject);  
        }
        else
            Destroy(this.gameObject);

        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
