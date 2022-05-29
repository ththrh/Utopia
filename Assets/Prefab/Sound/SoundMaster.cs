using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundMaster : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;
    public float sound;
    public bool bgm = true;

    private void Start()
    {
        if (bgm)
        {
            audioSlider.value = PlayerPrefs.GetFloat("BGM", -10);
        }
        else
        {
            audioSlider.value = PlayerPrefs.GetFloat("Effect", -10);
        }
    }
    public void AudioControl()
    {
        sound = audioSlider.value;
        if (bgm)
        {
            if (sound == -40f) masterMixer.SetFloat("BGM", -80);
            else masterMixer.SetFloat("BGM", sound);
            PlayerPrefs.SetFloat("BGM", sound);
        }
        else
        {
            if (sound == -40f) masterMixer.SetFloat("Effect", -80);
            else masterMixer.SetFloat("Effect", sound);
            PlayerPrefs.SetFloat("Effect", sound);
        }
    }
}
