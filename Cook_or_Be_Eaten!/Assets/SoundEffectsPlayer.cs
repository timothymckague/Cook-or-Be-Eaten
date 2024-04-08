using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource AudioSource_Kithen;
    public AudioClip sfx1;

    public void Kithen1()
    {
       AudioSource_Kithen.clip = sfx1;
       AudioSource_Kithen.Play();
    }
}
