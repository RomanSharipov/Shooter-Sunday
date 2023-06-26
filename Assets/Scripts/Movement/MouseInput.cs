using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class MouseInput : MonoBehaviour ,IInput
{
    private Vector2 _direction;
    public Vector2 Direction => _direction;

    public void ReadInput()
    {
        _direction.x = Input.GetAxis("Mouse X");
        _direction.y = Input.GetAxis("Mouse Y");
    }
}
