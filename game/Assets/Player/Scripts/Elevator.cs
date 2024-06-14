using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [Header("�������� �����")]
    [SerializeField] public Animator _animator;
    private bool elevatorUp;

    public void Up()
    {
        _animator.SetBool("elevatorUp", elevatorUp);
        elevatorUp = !elevatorUp;
    }
}
