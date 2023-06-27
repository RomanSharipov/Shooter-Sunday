using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private AnimationEvents _animationEvents;

    [SerializeField] private Weapon _weapon;

    private void OnEnable()
    {
        _animationEvents.Shot += _weapon.Shoot;
    }

    private void OnDisable()
    {
        _animationEvents.Shot -= _weapon.Shoot;
    }
}
