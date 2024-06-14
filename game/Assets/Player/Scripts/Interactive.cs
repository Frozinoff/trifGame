using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera _fpsCamera;
    private Ray _ray;
    public RaycastHit _hit;

    [Header("Звук открытия двери")]
    public AudioClip openDoor;

    [Header("Звук подбора ключа")]
    public AudioClip takeKey;

    [Header("Закрытая дверь")]
    public AudioClip closedDoor;

    [Header("Звук кнопки")]
    public AudioClip button;

    [Header("Привязать иконку ключа")]
    public GameObject key;

    List<Key> keyList;

    [Header("Расстояние взаимодействия")]
    [SerializeField] private float _maxDistanceray;

    [Header("Прицел полный")]
    public GameObject fullUI;

    public void pool()
    {
        GetComponent<AudioSource>().PlayOneShot(takeKey);
    }

    void Start()
    {
        keyList = new List<Key>();
    }




    public Text timerText;
    public int timeStart;
    public float timeStart1;
    private int min = 0;

    private void Update()
    {
        Aim();
        Ray();
        DrawRay();
        Interact();

        timeStart1 += Time.deltaTime;
        int timeStart = (int)timeStart1;
        if (timeStart == 60)
        {
            min++;
            timeStart1 = -1;
        }
        timerText.text = min.ToString("D2") + " : " + timeStart.ToString("D2");
    }

    private void Aim()
    {
        fullUI.SetActive(false);
    }

    private void Ray()
    {
        _ray = _fpsCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    public void DrawRay()
    {
        if (Physics.Raycast(_ray, out _hit, _maxDistanceray))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.blue);
        }

        if (_hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.red);
        }
    }

    public void Interact()
    {
        if (_hit.transform != null && _hit.transform.GetComponent<Door>())
        {
            fullUI.SetActive(true);
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (_hit.transform.GetComponent<Door>().isLocked)
                {
                    if (keyList.Count > 0)
                    {
                        for (int i = 0; i < keyList.Count; i++)
                        {
                            if (keyList[i].id == _hit.transform.GetComponent<Door>().id)
                            {
                                _hit.transform.GetComponent<Door>().Open();
                                _hit.transform.GetComponent<Door>().isLocked = false;
                                GetComponent<AudioSource>().PlayOneShot(openDoor);
                                 
                                key.SetActive(false);
                            }
                            else
                            {
                                GetComponent<AudioSource>().PlayOneShot(closedDoor);
                            }

                        }
                    }
                    else
                    {
                        GetComponent<AudioSource>().PlayOneShot(closedDoor);
                    }
                }
                else
                {
                    _hit.transform.GetComponent<Door>().Open();
                    GetComponent<AudioSource>().PlayOneShot(openDoor);
                }

            }
        }

        if (_hit.transform != null && _hit.transform.GetComponent<Key>())
        {
            fullUI.SetActive(true);
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (_hit.transform.GetComponent<Key>())
                {
                    GetComponent<AudioSource>().PlayOneShot(takeKey);
                    keyList.Add(_hit.transform.GetComponent<Key>());
                    Destroy(_hit.transform.GetComponent<Key>().gameObject);
                    Debug.Log(keyList.Count);
                    key.SetActive(true);
                }
            }

        }

        if (_hit.transform != null && _hit.transform.GetComponent<Elevator>())
        {
            fullUI.SetActive(true);
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                _hit.transform.GetComponent<Elevator>().Up();
                GetComponent<AudioSource>().PlayOneShot(button);
            }
        }

        if (_hit.transform != null && _hit.transform.GetComponent<Notes>())
        {
            fullUI.SetActive(true);
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                _hit.transform.GetComponent<Notes>().readNotes();
                Debug.Log("На записку нажали");
            }
        }

        if (_hit.transform != null && _hit.transform.GetComponent<wall>())
        {
            fullUI.SetActive(true);
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceray, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                _hit.transform.GetComponent<wall>().wallOpne();
                GetComponent<AudioSource>().PlayOneShot(button);
            }
        }
    }
   
}
