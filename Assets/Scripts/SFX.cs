using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public static AudioSource SFXSource;
    public static float SFXvolume;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        SFXSource = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("SFX"))
        {
            SFXvolume = 0.5f;
            PlayerPrefs.SetFloat("SFX", SFXvolume); // If it’s not, then save one
        }
      SFXSource.volume = PlayerPrefs.GetFloat("SFX");
    }
}
