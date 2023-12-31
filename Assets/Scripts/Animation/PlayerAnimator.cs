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

    private void OnDisable()
    {
        _groundCollisionHandler.GotOffGround -= GotOffGround;
        _groundCollisionHandler.Landed -= Landed;
        _inputMain.ClickedJump -= Jump;
        _inputMain.ClickedShoot -= Shoot;
    }

    private void OnEnable()
    {
        _groundCollisionHandler.GotOffGround += GotOffGround;
        _groundCollisionHandler.Landed += Landed;
        _inputMain.ClickedJump += Jump;
        _inputMain.ClickedShoot += Shoot;
    }

    private void Jump()
    {
        if (_groundCollisionHandler.IsGrounded)
        {
            _animator.SetTrigger(AnimatorConstants.Jump);
            _animator.SetBool(AnimatorConstants.IsGrounded,false);
        }
    }
    
    private void Landed()
    {
        _animator.SetBool(AnimatorConstants.IsGrounded, true);
        _animator.ResetTrigger(AnimatorConstants.Jump);
    }

    private void GotOffGround()
    {
        _animator.SetBool(AnimatorConstants.IsGrounded, false);
    }

    private void Shoot()
    {
        _animator.SetTrigger(AnimatorConstants.Shoot);
    }
}
