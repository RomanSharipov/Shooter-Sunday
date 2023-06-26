using UnityEngine;

public class JoystickInput : IInput
{
    private Joystick _joystick;
    private Vector2 _direction;
    
    public JoystickInput(Joystick joystick)
    {
        _joystick = joystick;
    }

    public Vector2 Direction => _direction;

    public void ReadInput()
    {
        _direction = _joystick.Direction;
    }
}
