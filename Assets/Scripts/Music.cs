using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public static AudioSource MusicSource;
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        MusicSource = GetComponent<AudioSource>();
    }

    public void StopMusic()
    {
        MusicSource.Stop();
    }
}
