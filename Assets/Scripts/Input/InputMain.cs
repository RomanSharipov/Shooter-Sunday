using System;
using UnityEngine;
using UnityEngine.UI;

public class InputMain : MonoBehaviour
{
    [SerializeField] private Joystick _joystickLeft;
    [SerializeField] private Joystick _joystickRight;
    [SerializeField] private Button _jumpButton;
    [SerializeField] private Button _shootButton;
    
    private IInput _movement;
    private IInput _rotation;
    
    public Vector2 MovementDirection => _movement.Direction;
    public Vector2 RotationDirection => _rotation.Direction;

    public event Action ClickedJump;
    public event Action ClickedShoot;

    private void Awake()
    {
        _movement = new JoystickInput(_joystickLeft);
        _rotation = new JoystickInput(_joystickRight);
    }

    private void OnEnable()
    {
        _jumpButton.onClick.AddListener(OnClickJump);
        _shootButton.onClick.AddListener(OnShootButton);
    }

    private void OnShootButton()
    {
        ClickedShoot?.Invoke();
    }

    private void OnDisable()
    {
        _jumpButton.onClick.RemoveListener(OnClickJump);
        _shootButton.onClick.RemoveListener(OnShootButton);
    }

    private void Update()
    {
        _movement.ReadInput();
        _rotation.ReadInput();
    }

    private void OnClickJump()
    {
        ClickedJump?.Invoke();
    }
}
