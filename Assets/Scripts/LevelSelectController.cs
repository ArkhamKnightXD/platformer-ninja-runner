﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectController : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.LevelSelect);
    }

    
}
