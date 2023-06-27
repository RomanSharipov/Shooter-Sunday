using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCollisionHandler : MonoBehaviour
{
    [SerializeField] private bool _isGrounded;

    public event Action Landed;
    public event Action GotOffGround;

    public bool IsGrounded => _isGrounded;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            Landed?.Invoke();
            _isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            GotOffGround?.Invoke();
            _isGrounded = false;
        }
    }
}
