using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    public static AudioSource SFXSource;
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        SFXSource = GetComponent<AudioSource>();
    }

}
