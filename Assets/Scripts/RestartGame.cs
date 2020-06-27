using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    string ActiveSceneName;


    void Start()
    {
        ActiveSceneName = SceneManager.GetActiveScene().name;
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(ActiveSceneName);
    }
}
