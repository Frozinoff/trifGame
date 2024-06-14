using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finalScreen : MonoBehaviour
{
    public Text timer;

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Next2lvl()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Урааа, второй уровень!!!");
    }

    public void Next3lvl()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Урааа, третий уровень!!!");
    }
}
