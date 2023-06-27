using System;
using UnityEngine;

public class GroundCollisionHandler : MonoBehaviour
{
    [SerializeField] private bool _isGrounded;

    public event Action Landed;
    public event Action GotOffGround;

    public bool IsGrounded => _isGrounded;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ground ground))
        {
            Landed?.Invoke();
            _isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Ground ground))
        {
            GotOffGround?.Invoke();
            _isGrounded = false;
        }
    }
}
