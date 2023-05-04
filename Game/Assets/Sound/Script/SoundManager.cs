using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource effectSource; 

    /*public enum soundName
    {
        Siren,
        Explosion,
        Magic
    }*/

    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClip[count]);
    }

    public void Volume(float volume)
    {
        soundSource.volume = volume;
    }
}