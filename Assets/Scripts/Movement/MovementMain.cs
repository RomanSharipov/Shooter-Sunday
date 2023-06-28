using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMain : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private AnimationEvents _animationEvents;
    [SerializeField] private RotatorZ _rotatorZ;

    private IMovable _movement;
    private RigidbodyJumping _rigidbodyJumping;
    private RotatorY _rotatorY;

    private void Awake()
    {
        _movement = new RigidbodyMovement(_rigidbody, transform);
        _rigidbodyJumping = new RigidbodyJumping(_rigidbody, _animationEvents);
        _rotatorY = new RotatorY(_inputMain, transform);
    }

    private void Update()
    {
        _movement.Move(_inputMain.MovementDirection);
        _rotatorY.RotateY(_inputMain.RotationDirection);
        _rotatorZ.RotateZ(_inputMain.RotationDirection);
    }

    private void OnDisable()
    {
        _rigidbodyJumping.OnDisable();
    }
}
