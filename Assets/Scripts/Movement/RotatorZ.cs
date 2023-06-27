using UnityEngine;

public class RotatorZ : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float rotationAngleMin = -45f;
    [SerializeField] private float rotationAngleMax = 45f;

    private float rotationX = 0.0f;
    
    private void Update()
    {
        Vector2 rotationDirection = _inputMain.RotationDirection;
        RotateObject(rotationDirection);
    }
    
    private void RotateObject(Vector2 rotationDirection)
    {
        rotationX -= rotationSpeed * rotationDirection.y;
        rotationX = Mathf.Clamp(rotationX, rotationAngleMin, rotationAngleMax);
        transform.localEulerAngles = new Vector3(rotationX, 0, 0);
    }
}
