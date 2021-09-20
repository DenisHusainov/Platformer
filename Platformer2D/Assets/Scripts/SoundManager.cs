using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource _audioSource;
    [SerializeField] private AudioClip _back;
    [SerializeField] private AudioClip _collision;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    //private void Start()
    //{
    //    _audioSource.PlayOneShot(_back);
    //}

    public void AudioCollision()
    {
        if (!_audioSource.isPlaying)
        {
          _audioSource.PlayOneShot(_collision);
        }
       
    }
}
