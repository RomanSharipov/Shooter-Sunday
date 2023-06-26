using System;
using System.Collections;
using UnityEngine;

public class MovementMain : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private float _moveSpeed = 3.0f;
    [SerializeField] private float _jumpForce = 5.0f;
    [SerializeField] private float _jumpTime = 0.5f;
    [SerializeField] private AnimationCurve _jumpCurve;
    [SerializeField] private float _ySpeed;

    private void Update()
    {
        Vector3 localMovementDirection = new Vector3(_inputMain.MovementDirection.x, _ySpeed, _inputMain.MovementDirection.y);
        Vector3 worldMovementDirection = transform.TransformDirection(localMovementDirection);

        _characterController.Move(worldMovementDirection * _moveSpeed * Time.deltaTime);

        ApplyGravity();
    }

    private void ApplyGravity()
    {
        Vector3 gravity = Physics.gravity;
        _characterController.Move(gravity * Time.deltaTime);
    }

    private void OnEnable()
    {
        _inputMain.ClickedJump += OnClickJump;
    }

    private void OnDisable()
    {
        _inputMain.ClickedJump -= OnClickJump;
    }

    private void OnClickJump()
    {
        if (_characterController.isGrounded)
        {
            StartCoroutine(JumpCoroutine());
        }
    }
    
    private IEnumerator JumpCoroutine()
    {
        float elapsedTime = 0f;
        float normalizedTime = 0f;
        float initialYSpeed = _jumpForce;
        float finalYSpeed = -1f;

        while (normalizedTime < 1f)
        {
            elapsedTime += Time.deltaTime;
            normalizedTime = Mathf.Clamp01(elapsedTime / _jumpTime);
            float curveValue = _jumpCurve.Evaluate(normalizedTime);
            _ySpeed = Mathf.Lerp(initialYSpeed, finalYSpeed, curveValue);
            yield return null;
        }

        _ySpeed = finalYSpeed;
    }
}
