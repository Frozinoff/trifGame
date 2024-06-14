using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public static bool GameNotes = false;

    public GameObject NotesUI;

    [Header("Звук записки")]
    public AudioClip clip;

    public void readNotes()
    {
        NotesUI.SetActive(true);
        Time.timeScale = 0f;
        GameNotes = true;
        Cursor.lockState = CursorLockMode.None;
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public void stopreadNotes()
    {
        NotesUI.SetActive(false);
        Time.timeScale = 1f;
        GameNotes = false;
        Cursor.lockState = CursorLockMode.Locked;
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
