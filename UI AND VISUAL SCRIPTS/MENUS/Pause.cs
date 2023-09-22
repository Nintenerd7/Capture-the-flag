using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused;

    [SerializeField] GameObject pauseMenu;
    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;//pauses menu
        isPaused = true;

    }


    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
        isPaused = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);//loads title screen
    }
}

