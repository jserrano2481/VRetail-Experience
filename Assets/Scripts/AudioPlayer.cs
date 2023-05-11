using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("PlayAudioClip", 5f);
    }

    private void PlayAudioClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}

