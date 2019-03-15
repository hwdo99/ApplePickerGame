using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public SFX SFXScript;
    public Music MusicScript;
    AudioSource musicSource;
    AudioSource sfxSource;
    public Slider MusicSlider;
    public Slider SFXslider;

    public void Awake()
    {
        musicSource = GameObject.FindWithTag("Music").GetComponent<AudioSource>();
        sfxSource = GameObject.FindWithTag("SFX").GetComponent<AudioSource>();
        SFXslider.value = PlayerPrefs.GetFloat("SFX");
        MusicSlider.value = PlayerPrefs.GetFloat("Music");
    }
    public void Update()
    {
        sfxSource.volume = SFX.SFXvolume;
        musicSource.volume = Music.musicVolume;
        PlayerPrefs.Save();
    }

    public void SetMusicVolume (float volume)
    {
        Music.musicVolume = volume;
        PlayerPrefs.SetFloat("Music", volume);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float volume)
    {
        SFX.SFXvolume = volume;
        PlayerPrefs.SetFloat("SFX", volume);
        PlayerPrefs.Save();
    }
}
