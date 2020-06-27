using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource GameSong;

    public AudioSource DamageTaken;

    public AudioSource FruitGet;

    public AudioSource Invulnerable;

    public AudioSource PlayerJump;

    public AudioSource GameOver;

    public AudioSource Win;

    public AudioSource Menu;

    public AudioSource LevelSelect;

    private void Awake()
    {
        Instance = this;
    }
    
    public enum SoundEffect
    {
        GameSong,
        DamageTaken,
        FruitGet,
        Invulnerable,
        PlayerJump,
        Win,
        Menu,
        LevelSelect,
        GameOver
    }

    public void PlaySoundEffect(SoundEffect type)
    {
        switch (type)
        {
        case SoundEffect.GameSong:
            GameSong.Play();
            break;

        case SoundEffect.DamageTaken:
            DamageTaken.Play();
            break;

        case SoundEffect.FruitGet:
            FruitGet.Play();
            break;

        case SoundEffect.Invulnerable:
            Invulnerable.Play();
            GameSong.Stop();
            break;

        case SoundEffect.PlayerJump:
            PlayerJump.Play();
            break;

        case SoundEffect.Win:
            GameSong.Stop();
            Win.Play();
            break;

        case SoundEffect.GameOver:
            GameSong.Stop();
            GameOver.Play();
            break;

        case SoundEffect.Menu:
            Menu.Play();
            break;
        
        case SoundEffect.LevelSelect:
            LevelSelect.Play();
            break;
            
        }
    }
}
