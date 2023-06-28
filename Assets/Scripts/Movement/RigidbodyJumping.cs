using UnityEngine;

public class RigidbodyJumping 
{
    private Rigidbody _rigidbody;
    private AnimationEvents _animationEvents;
    private float _forceJump = 350.0f;

    public RigidbodyJumping(Rigidbody rigidbody, AnimationEvents animationEvents)
    {
        _rigidbody = rigidbody;
        _animationEvents = animationEvents;
        _animationEvents.Jumped += JumpRigidbody;
    }
    
    public void OnDisable()
    {
        _animationEvents.Jumped -= JumpRigidbody;
    }
    
    private void JumpRigidbody()
    {
        _rigidbody.AddForce(Vector3.up * _forceJump * Time.deltaTime,ForceMode.Impulse) ;
    }
}
