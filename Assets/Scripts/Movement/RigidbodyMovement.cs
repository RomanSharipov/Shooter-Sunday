using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float _moveSpeed = 3.0f;
    private Vector3 _direction = new Vector3();

    private void Update()
    {
        //Vector3 localMovementDirection = new Vector3(_inputMain.MovementDirection.x, 0, _inputMain.MovementDirection.y);
        //Vector3 worldMovementDirection = transform.TransformDirection(localMovementDirection);
        //_characterController.Move(worldMovementDirection * _moveSpeed * Time.deltaTime);
        //ApplyGravity();
        Walk(_inputMain.MovementDirection);

    }

    private void Walk(Vector2 direction)
    {
        _direction = transform.right * direction.x + transform.forward * direction.y;
        _rigidbody.velocity = _direction * _moveSpeed + Vector3.up * _rigidbody.velocity.y;
    }
}
