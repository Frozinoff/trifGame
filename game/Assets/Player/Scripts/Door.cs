using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Привязка всей двери")]
    [SerializeField] public Animator _animator; 
    private bool _isOpened;
    private bool _isClosed;
    [Header("Дверь с ключем ?")]
    public bool isLocked;
    [Header("Id Двери с ключем(одинаковые)")]
    public int id;


    public void Open()
    {
        _animator.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
    }



    

}
