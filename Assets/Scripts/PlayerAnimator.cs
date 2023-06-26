using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputMain _inputMain;
    [SerializeField] private GroundCollisionHandler _groundCollisionHandler;

    private void Update()
    {
        _animator.SetFloat(AnimatorConstants.Horizontal, _inputMain.MovementDirection.x);
        _animator.SetFloat(AnimatorConstants.Vertical, _inputMain.MovementDirection.y);
    }

    private void OnEnable()
    {
        _groundCollisionHandler.GotOffGround += GotOffGround;
        _groundCollisionHandler.Landed += Landed;
        _inputMain.ClickedJump += Jump;
    }

    private void Jump()
    {
        _animator.SetTrigger(AnimatorConstants.Jump);
    }

    private void OnDisable()
    {
        _groundCollisionHandler.GotOffGround -= GotOffGround;
        _groundCollisionHandler.Landed -= Landed;
        _inputMain.ClickedJump -= Jump;
    }

    private void Landed()
    {
        _animator.SetTrigger(AnimatorConstants.Land);
    }

    private void GotOffGround()
    {
        _animator.SetTrigger(AnimatorConstants.GotOffLand);
    }
}
