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

    public void AudioControl()
    {
        sound = audioSlider.value;
        if (sound == -40f) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", sound);
    }
}
