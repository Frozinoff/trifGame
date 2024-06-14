using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerOut2 : MonoBehaviour
{
    public GameObject finalScreen;
    public Interactive playerInteractive;
    public GameObject timerAim;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {




            finalScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("����� ������");
            timerAim.SetActive(false);
        }
    }

    public void Nextlvl2()
    {
        SceneManager.LoadScene(2);
        Debug.Log("�����, ������ �������!!!");
    }

    public void Nextlvl3()
    {
        SceneManager.LoadScene(3);
        Debug.Log("�����, ������ �������!!!");
    }

}
