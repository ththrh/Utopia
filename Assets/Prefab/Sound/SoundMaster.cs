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

    private void Start()
    {
        audioSlider.value = PlayerPrefs.GetFloat("BGM", -10);
    }
    public void AudioControl()
    {
        sound = audioSlider.value;
        Debug.Log(sound);
        if (sound == -40f) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", sound);
        PlayerPrefs.SetFloat("BGM", sound);

        Debug.Log(sound);
        if (sound == -40f) masterMixer.SetFloat("Effect", -80);
        else masterMixer.SetFloat("Effect", sound);
        Debug.Log(sound);
    }
}
