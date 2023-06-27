using UnityEngine;

public class RotatorY : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private InputMain _inputMain;
    
    private float rotationY = 0.0f;

    private void Update()
    {
        Vector2 rotationDirection = _inputMain.RotationDirection;
        RotateObject(rotationDirection);
    }

    private void RotateObject(Vector2 rotationDirection)
    {
        rotationY = rotationSpeed * rotationDirection.x;
        transform.rotation *= Quaternion.Euler(0, rotationY, 0);
    }
}
