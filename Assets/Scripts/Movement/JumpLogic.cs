using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpLogic : MonoBehaviour
{
    [SerializeField] private AnimationCurve _jumpCurve;
    [SerializeField] private float _jumpForce = 5.0f;
    [SerializeField] private float _jumpTime = 0.5f;
    [SerializeField] private GroundCollisionHandler _groundCollisionHandler;
    [SerializeField] private float _ySpeed;

    public float YSpeed => _ySpeed;

    public void Jump()
    {

        StartCoroutine(JumpCoroutine());
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
