using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMain : MonoBehaviour
{
    private IInput _input;

    private void Update()
    {
        _input.ReadInput();
    }
}
