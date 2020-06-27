using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{


    void Start()
    {
        AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Menu);
    }
    public void PlayGame()
    {
        // Esto cargara la escena cuyo index en el build se uno mas que el menu 
        // pues el menu sera el index 0
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
