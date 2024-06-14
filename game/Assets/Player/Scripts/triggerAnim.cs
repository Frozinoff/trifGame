using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnim : MonoBehaviour
{
    public GameObject audio;

    [Header("Привязать триггер")]
    public GameObject nole1;

    [Header("Привязать пол")]
    public GameObject nole2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playAudio();
            nole2.SetActive(false);
            nole1.SetActive(false);
        }
    }

    void playAudio ()
    {
        audio.SetActive(true);
    }
 
}


