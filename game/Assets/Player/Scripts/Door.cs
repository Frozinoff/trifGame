using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("�������� ���� �����")]
    [SerializeField] public Animator _animator; 
    private bool _isOpened;
    private bool _isClosed;
    [Header("����� � ������ ?")]
    public bool isLocked;
    [Header("Id ����� � ������(����������)")]
    public int id;


    public void Open()
    {
        _animator.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
    }



    

}
