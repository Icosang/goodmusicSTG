﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource[] audioSource;
    public Dictionary<string, AudioSource> sounds { get; set; }

    private void Awake()
    {
        audioSource = GetComponents<AudioSource>();
        sounds = new Dictionary<string, AudioSource>();

        sounds.Add("DEAD", audioSource[0]);
        sounds.Add("DEFEATED", audioSource[1]);
        sounds.Add("SPELLCARD", audioSource[2]);
        sounds.Add("1635", audioSource[3]);
        sounds.Add("Bunnyhop", audioSource[4]);
        sounds.Add("Bullet", audioSource[5]);
        sounds.Add("Bullet2", audioSource[6]);
    }


    //ex      SoundManager.sounds["Effect_Jump"].Play();

}
