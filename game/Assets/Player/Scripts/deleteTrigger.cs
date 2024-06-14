using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteTrigger : MonoBehaviour
{
    [Header("Привязать триггер1")]
    public GameObject nole;

    [Header("Привязать триггер2")]
    public GameObject nole2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            nole.SetActive(false);
            nole2.SetActive(false);
        }
    }
}
