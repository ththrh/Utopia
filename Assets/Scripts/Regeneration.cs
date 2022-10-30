using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regeneration : MonoBehaviour
{
    public GameObject[] mychildren;
    public Vector3[] cPosition;
    public GameObject Player;
    public int cnt = 0;
    public GameObject fence;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach (GameObject child in mychildren)
        {
            cPosition[i] = child.transform.position;
            i++;
        }
        cnt = mychildren.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            int i = 0;
            foreach (GameObject child in mychildren)
            {
                child.transform.position = cPosition[i];
                i++;
            }
        }
        if(cnt <= 0)
        {
            foreach(GameObject child in mychildren)
            {
                Destroy(child);
            }
        }
    }
    public void destroyFence()
    {
        Destroy(fence);
    }
}
