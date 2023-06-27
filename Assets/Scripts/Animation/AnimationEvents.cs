using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public event Action Jumped;
    public event Action Shot;

    public void JumpEvent()
    {
        Jumped?.Invoke();
    }

    public void ShootEvent()
    {
        Shot?.Invoke();
    }
}
