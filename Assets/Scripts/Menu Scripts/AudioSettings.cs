using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

   public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("AudioVolume",MathF.Log10(sliderValue) * 20);
    }
}

