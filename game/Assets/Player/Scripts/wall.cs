using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [Header("�������� ���� �����")]
    [SerializeField] public Animator _animator;
    private bool openWall;

    public void wallOpne()
    {
        _animator.SetBool("openWall", openWall);
        openWall = !openWall;
        Debug.Log("����� �������");
    }


}

