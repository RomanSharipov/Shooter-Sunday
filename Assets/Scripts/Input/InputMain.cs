using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMain : MonoBehaviour
{
    [SerializeField] private Joystick _joystickLeft;
    [SerializeField] private Joystick _joystickRight;
    [SerializeField] private TouchInput _touchInput;
    
    private IInput _movement;
    private IInput _rotation;
    
    public Vector2 MovementDirection => _movement.Direction;
    //public Vector2 RotationDirection => _touchInput.Direction;
    public Vector2 RotationDirection => _rotation.Direction;

    private void Awake()
    {
        _movement = new JoystickInput(_joystickLeft);
        _rotation = new JoystickInput(_joystickRight);
        //_rotation = new MouseInput();
    }

    private void Update()
    {
        _movement.ReadInput();
        _rotation.ReadInput();
    }
}
