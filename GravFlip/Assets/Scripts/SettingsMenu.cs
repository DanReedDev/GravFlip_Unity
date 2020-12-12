using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public Dropdown ddDifficulty;
    public Dropdown ddQuality;
    public Slider fxSlider;
    public Slider masterSlider;
    int difficulty;
    int quality;


    void Start()
    {
        ddDifficulty.onValueChanged.AddListener(delegate
        {
            SetDifficulty(ddDifficulty);
        });

        ddQuality.onValueChanged.AddListener(delegate
        {
            SetQuality(ddQuality);
        });

        fxSlider.value = PlayerPrefs.GetFloat("FXVolume", 0.75f);
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume", 0.75f);
    }

    void Update()
    {
        ddDifficulty.value = PlayerPrefs.GetInt("Difficutly", difficulty);
        ddQuality.value = PlayerPrefs.GetInt("Quality", quality);
    }

    public void SetFXVolume(float fxVolume)
    {
        audioMixer.SetFloat("FXVolume", fxVolume);
        PlayerPrefs.SetFloat("FXVolume", fxVolume);
    }

    public void SetMasterVolume(float masterVolume)
    {
        audioMixer.SetFloat("masterVolume", masterVolume);
        PlayerPrefs.SetFloat("masterVolume", masterVolume);
    }

    public void SetQuality (Dropdown sender)
    {
        PlayerPrefs.SetInt("Quality", sender.value);
        quality = PlayerPrefs.GetInt("Quality");
        QualitySettings.SetQualityLevel(sender.value);
    }

    public void SetDifficulty (Dropdown sender)
    {
        PlayerPrefs.SetInt("Difficutly", sender.value);
        difficulty = PlayerPrefs.GetInt("Difficutly");
    }

}
