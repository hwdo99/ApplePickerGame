using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static AudioSource MusicSource;
    public static float musicVolume;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        MusicSource = GetComponent<AudioSource>();
        musicVolume = 0.5f;
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetFloat("Music", musicVolume); // If it’s not, then save one
        }
        MusicSource.volume = PlayerPrefs.GetFloat("Music");
    }
}
