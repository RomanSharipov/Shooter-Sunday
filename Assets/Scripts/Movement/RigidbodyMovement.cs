using UnityEngine;

public class RigidbodyMovement : IMovable
{
    private Rigidbody _rigidbody;
    private float _moveSpeed = 3.0f;
    private Transform _transform;

    private Vector3 _direction = new Vector3();

    public RigidbodyMovement(Rigidbody rigidbody,Transform transform)
    {
        _rigidbody = rigidbody;
        _transform = transform;
    }

    public void Move(Vector2 direction)
    {
        _direction = _transform.right * direction.x + _transform.forward * direction.y;
        _rigidbody.velocity = _direction * _moveSpeed + Vector3.up * _rigidbody.velocity.y;
    }
}
