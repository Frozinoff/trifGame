using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteTrigger : MonoBehaviour
{
    [Header("��������� �������1")]
    public GameObject nole;

    [Header("��������� �������2")]
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
