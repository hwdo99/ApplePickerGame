using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
