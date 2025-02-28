using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;  

public class SettingsHandler : MonoBehaviour
{
    public Slider musicVolumeSider;
    public AudioMixer musicMixer;
    public Slider SFXSlider;
    private void Start()
    {
        musicVolumeSider.value = PlayerPrefs.GetFloat("MusicVolume");

        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");


    }

    public void ChangeMusicVolume()
    {
        musicMixer.SetFloat("MusicVolume", musicVolumeSider.value);
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSider.value);
    }
   
    public void ChangeSFXVolume()
    {
        musicMixer.SetFloat("SFXVolume", SFXSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }
    
    








}

