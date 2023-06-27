using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private Transform _bulletSpawnPoint;

    public override void Shoot()
    {
        Instantiate(_bulletTemplate, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
    }
}

