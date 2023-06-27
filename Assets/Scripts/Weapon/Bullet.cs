using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speedFly;

    private void Update()
    {
        transform.position += transform.forward * _speedFly * Time.deltaTime;
    }
}
