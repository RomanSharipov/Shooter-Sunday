using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private Transform _bulletSpawnPoint;

    public override void Shoot()
    {
        Debug.Log("Shoot");
        Instantiate(_bulletTemplate, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
    }
}

