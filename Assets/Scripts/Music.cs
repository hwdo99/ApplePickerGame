using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Slider MusicSlider;
    public static AudioSource MusicSource;
    private float musicVolume = 0.5f;
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        MusicSource = GetComponent<AudioSource>();
        MusicSlider.value = PlayerPrefs.GetFloat("Music volume");
    }
    public void Update()
    {
        MusicSource.volume = musicVolume;
    }

    public void OnSliderChange(float volume)
    {
        musicVolume = volume;
        PlayerPrefs.SetFloat("Music volume", volume);
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void StopMusic()
    {
        MusicSource.Stop();
    }
}
