using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMove : MonoBehaviour
{
    public static int nextScene;

    [SerializeField]
    Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChange()
    {
        LoadingSceneManager.LoadScene(2);
    }


}
