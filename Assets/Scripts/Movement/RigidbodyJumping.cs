using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyJumping : MonoBehaviour
{
    [SerializeField] private float _forceJump;
    [SerializeField] private Rigidbody _rigidbody;


    public void JumpRigidbody()
    {
        Debug.Log("Jump");
        _rigidbody.AddForce(Vector3.up * _forceJump * Time.deltaTime,ForceMode.Impulse) ;
    }
}
