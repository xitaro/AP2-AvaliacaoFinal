using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public static bool gameIsPaused;

    public void Load(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public static void PauseGame()
    {
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
    }
}
