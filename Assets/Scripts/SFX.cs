using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    public Slider SFXslider;
    public static AudioSource SFXSource;
    private float SFXvolume = 0.5f;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        SFXSource = GetComponent<AudioSource>();
        SFXslider.value = PlayerPrefs.GetFloat("SFX volume");
    }
    public void Update()
    {
        SFXSource.volume = SFXvolume;
    }

    public void OnSliderChange(float volume)
    {
        SFXvolume = volume;
        PlayerPrefs.SetFloat("SFX volume", volume);
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
