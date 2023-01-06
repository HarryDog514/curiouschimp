using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSoundsv2 : MonoBehaviour
{
    public List<AudioSource> HitSounds;
    public AudioClip[] stone;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {

        foreach (AudioSource source in HitSounds)
        {
            if (other.gameObject.tag == "Grass")
            {
                HitSounds[0].Play();
            }
            if (other.gameObject.tag == "Tree")
            {
                HitSounds[1].Play();
            }
            if (other.gameObject.tag == "Wood")
            {
                HitSounds[2].Play();
            }
            if (other.gameObject.tag == "Metal")
            {
                HitSounds[3].Play();
            }
            if (other.gameObject.tag == "Stone")
            {
                PlayRandomConcrete();
            }
            if (other.gameObject.tag == "Glass")
            {
                HitSounds[5].Play();
            }
            if (other.gameObject.tag == "Snow")
            {
                HitSounds[6].Play();
            }
            if (other.gameObject.tag == "Dirt")
            {
                HitSounds[7].Play();
            }
            if (other.gameObject.tag == "Carpet")
            {
                HitSounds[8].Play();
            }
        }

        void PlayRandomConcrete()
        {
            audioSource.clip = stone[Random.Range(0, stone.Length)];
            audioSource.Play();
        }
    }
}
