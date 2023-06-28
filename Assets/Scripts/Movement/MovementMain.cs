using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMain : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private AnimationEvents _animationEvents;

    private IMovable _movement;
    private RigidbodyJumping _rigidbodyJumping;

    private void Awake()
    {
        _movement = new RigidbodyMovement(_rigidbody, transform);
        _rigidbodyJumping = new RigidbodyJumping(_rigidbody, _animationEvents);
    }

    private void Update()
    {
        _movement.Move(_inputMain.MovementDirection);
    }

    private void OnDisable()
    {
        _rigidbodyJumping.OnDisable();
    }
}
