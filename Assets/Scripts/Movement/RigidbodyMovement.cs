using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float _moveSpeed = 3.0f;

    private Vector3 _direction = new Vector3();

    private void Update()
    {
        Walk(_inputMain.MovementDirection);
    }

    private void Walk(Vector2 direction)
    {
        _direction = transform.right * direction.x + transform.forward * direction.y;
        _rigidbody.velocity = _direction * _moveSpeed + Vector3.up * _rigidbody.velocity.y;
    }
}
