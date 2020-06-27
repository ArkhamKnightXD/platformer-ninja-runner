using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }

            else{
                PauseGame();
            }
        }
    }


    public void ResumeGame()
    {
        PauseMenuUI.SetActive(false);

        // Con esto devolvemos el juego a su velocidad normal que es 1f
        Time.timeScale = 1f;

        GameIsPaused = false;
    }


    public void PauseGame()
    {
        PauseMenuUI.SetActive(true);

        // Con esto pausamos el tiempo y por ende el juego en general
        Time.timeScale = 0f;

        GameIsPaused = true;
    }


    public void LoadLevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
    }


    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
