using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  
    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }

    public void Restart1()
    {
        SceneManager.LoadScene(1);
    }

    public void voidMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
