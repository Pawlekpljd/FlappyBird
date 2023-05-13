using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioMixer mainAudioMixer;

    public void ChangeMusicVolume(float sliderValue)
    {
        mainAudioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }
    public void ChangeSoundVolume(float sliderValue)
    {
        mainAudioMixer.SetFloat("SoundVolume", Mathf.Log10(sliderValue) * 20);
    }



}
