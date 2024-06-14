using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

        public static bool Instr = true;

    public GameObject instrUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        instrUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restar1lvl()
    {
        SceneManager.LoadScene(1);
    }

    public void Restar2lvl()
    {
        SceneManager.LoadScene(2);
    }

    public void Restar3lvl()
    {
        SceneManager.LoadScene(3);
    }



}
