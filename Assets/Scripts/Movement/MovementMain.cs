using UnityEngine;

public class MovementMain : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float _moveSpeed = 3.0f;
    [SerializeField] private JumpLogic _jumpLogic;
    
    private void Update()
    {
        Vector3 localMovementDirection = new Vector3(_inputMain.MovementDirection.x, _jumpLogic.YSpeed, _inputMain.MovementDirection.y);
        Vector3 worldMovementDirection = transform.TransformDirection(localMovementDirection);
        _characterController.Move(worldMovementDirection * _moveSpeed * Time.deltaTime);
        ApplyGravity();
        
    }

    private void ApplyGravity()
    {
        Vector3 gravity = Physics.gravity;
        _characterController.Move(gravity * Time.deltaTime);
    }
}
