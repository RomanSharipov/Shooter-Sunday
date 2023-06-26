using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCollisionHandler : MonoBehaviour
{
    [SerializeField] private float _lenghtRay = 1.08f;
    [SerializeField] private LayerMask _groundLayerMask;
    
    public event Action Landed;
    public event Action GotOffGround;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (IsGrounded())
        {
            Landed?.Invoke();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (IsGrounded())
            return;
        
        GotOffGround?.Invoke();
    }

    public bool IsGrounded()
    {
        Ray ray = new Ray(transform.position, Vector3.down * _lenghtRay);
        
        if (Physics.Raycast(ray, _lenghtRay, _groundLayerMask))
        {
            return true;
        }
        return false;
    }
}
