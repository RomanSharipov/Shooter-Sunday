using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    [SerializeField] private Button _jumpButton;

    public event Action ClickedJump;

    private void OnEnable()
    {
        _jumpButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _jumpButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        ClickedJump?.Invoke();
    }
}
