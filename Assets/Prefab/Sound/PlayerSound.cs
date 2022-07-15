using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    AudioSource audio;
    Status stat;
    bool qCool = false;
    bool sCool = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        stat = GetComponentInParent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stat.q_isactiveskill_1)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !qCool)
            {
                qCool = true;
                StartCoroutine(qCooldown(3f));
                audio.clip = audioClips[0];
                audio.Play();
            }
        }
        else if (stat.q_isactiveskill_2)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !qCool)
            {
                qCool = true;
                StartCoroutine(qCooldown(3f));
                audio.clip = audioClips[1];
                audio.Play();
            }
        }
        else if (stat.q_isactiveskill_3)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !qCool)
            {
                qCool = true;
                StartCoroutine(qCooldown(3f));
                audio.clip = audioClips[2];
                audio.Play();
            }
        }

        if (stat.shift_isactiveskill_1)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !sCool)
            {
                sCool = true;
                StartCoroutine(sCooldown(10f));
                audio.clip = audioClips[3];
                audio.Play();
            }
        }
        else if (stat.shift_isactiveskill_2)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !sCool)
            {
                sCool = true;
                StartCoroutine(sCooldown(6f));
                audio.clip = audioClips[4];
                audio.Play();
            }
        }
        else if (stat.shift_isactiveskill_3)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !sCool)
            {
                sCool = true;
                StartCoroutine(sCooldown(10f));
                audio.clip = audioClips[5];
                audio.Play();
            }
        }
        else if (stat.shift_isactiveskill_4)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !sCool)
            {
                sCool = true;
                StartCoroutine(sCooldown(8f));
                audio.clip = audioClips[6];
                audio.Play();
            }
        }
    }

    IEnumerator qCooldown(float f)
    {
        yield return new WaitForSeconds(f);
        qCool = false;
    }
    IEnumerator sCooldown(float f)
    {
        yield return new WaitForSeconds(f);
        sCool = false;
    }
}
