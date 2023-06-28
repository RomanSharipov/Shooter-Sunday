using UnityEngine;

public class RotatorY 
{
    private InputMain _inputMain;
    private Transform _transform;
    private float rotationSpeed = 12.0f;
    private float rotationY;

    public RotatorY(InputMain inputMain, Transform transform)
    {
        _inputMain = inputMain;
        _transform = transform;
    }

    public void RotateY(Vector2 rotationDirection)
    {
        RotateObject(rotationDirection);
    }

    private void RotateObject(Vector2 rotationDirection)
    {
        rotationY = rotationSpeed * rotationDirection.x;
        _transform.rotation *= Quaternion.Euler(0, rotationY, 0);
    }
}
