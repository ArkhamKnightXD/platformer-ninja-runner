using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButtons : MonoBehaviour
{
    public void OnMouseDown(){
        if (gameObject.name == "Level1")
        {
            SceneManager.LoadScene("NinjaRunner");
        }

        if (gameObject.name == "Level2")
        {
            SceneManager.LoadScene("Level2");
        }

        if (gameObject.name == "ExitButton")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
