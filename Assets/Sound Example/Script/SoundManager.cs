using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }
    public void VolumeControl(float volume)
    {
        audioSource.volume = volume;
    }
    public void SoundCall(string name)
    {
        switch(name) // <-이름에 조건이 들어옴
        {
            case "Siren" : audioSource.clip = audioClip[0];
                audioSource.Play();
                break;
            case "Explosion" : audioSource.clip = audioClip[1];
                audioSource.Play();
                break;
            case "Magic" :audioSource.clip = audioClip[2];
                audioSource.Play();
                break;
        }
    }
}
