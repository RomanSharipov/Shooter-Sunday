using UnityEngine;

public class RotatorZ : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 6f;
    [SerializeField] private float rotationAngleMin = -45f;
    [SerializeField] private float rotationAngleMax = 45f;

    private float rotationX;
    
    public void RotateZ(Vector2 rotationDirection)
    {
        RotateObject(rotationDirection);
    }
    
    private void RotateObject(Vector2 rotationDirection)
    {
        rotationX -= rotationSpeed * rotationDirection.y;
        rotationX = Mathf.Clamp(rotationX, rotationAngleMin, rotationAngleMax);
        transform.localEulerAngles = new Vector3(rotationX, 0, 0);
    }
}
