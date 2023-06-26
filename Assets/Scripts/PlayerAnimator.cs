using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputMain _inputMain;

    private void Update()
    {
        _animator.SetFloat(AnimatorConstants.Horizontal, _inputMain.MovementDirection.x);
        _animator.SetFloat(AnimatorConstants.Vertical, _inputMain.MovementDirection.y);
    }
}
