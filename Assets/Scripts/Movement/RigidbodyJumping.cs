using UnityEngine;

public class RigidbodyJumping : MonoBehaviour
{
    [SerializeField] private float _forceJump;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private AnimationEvents _animationEvents;
    
    private void OnEnable()
    {
        _animationEvents.Jumped += JumpRigidbody;
    }

    private void OnDisable()
    {
        _animationEvents.Jumped -= JumpRigidbody;
    }
    
    private void JumpRigidbody()
    {
        _rigidbody.AddForce(Vector3.up * _forceJump * Time.deltaTime,ForceMode.Impulse) ;
    }
}
