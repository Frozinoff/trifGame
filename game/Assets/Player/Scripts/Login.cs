using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField ono;
    public Text nameUser;
    public static string name2;
    string nool = "";
    public GameObject non;
    public GameObject Log;


    public void Update()
    {
        name2 = nameUser.text;

    }

    public void Tup()
    {
        if (name2 == nool)
        {
            Debug.Log("Имя не ввели");
            non.SetActive(true);
        }
        else
        {
            Debug.Log("Ввели имя");
            Log.SetActive(false);
        }
    }
}
