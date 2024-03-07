using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;

    [Header("----------Audio Clip------------")]
    public AudioClip background;


    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
