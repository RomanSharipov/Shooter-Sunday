using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speedFly;
    [SerializeField] private ParticleSystem _collisionEffect;

    private void Update()
    {
        transform.position += transform.forward * _speedFly * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(_collisionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
