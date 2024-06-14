using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    [Header("Чувствительность мыши")]
    public float mouseSensitivity = 100f;

    [Header("Привязка персонажа")]
    public Transform playerBody;

    float XRotation = 0f; 

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
