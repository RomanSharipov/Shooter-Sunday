using UnityEngine;

public class MovementMain : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float _moveSpeed = 3.0f;

    private void Update()
    {
        Vector3 localMovementDirection = new Vector3(_inputMain.MovementDirection.x, 0, _inputMain.MovementDirection.y);
        Vector3 worldMovementDirection = transform.TransformDirection(localMovementDirection);

        _characterController.SimpleMove(worldMovementDirection * _moveSpeed * Time.deltaTime);
    }
}
