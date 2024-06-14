using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [Header("Привязка всей двери")]
    [SerializeField] public Animator _animator;
    private bool openWall;

    public void wallOpne()
    {
        _animator.SetBool("openWall", openWall);
        openWall = !openWall;
        Debug.Log("Стена открыта");
    }


}

