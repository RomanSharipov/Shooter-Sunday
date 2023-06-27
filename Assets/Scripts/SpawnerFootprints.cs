using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFootprints : MonoBehaviour
{
    [SerializeField] private Footprint _footprintTemplate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ground ground))
        {
            Footprint newFootprint = Instantiate(_footprintTemplate,transform.position,Quaternion.identity);
            newFootprint.transform.Rotate(-90,0,0);
            newFootprint.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        }
    }
}
