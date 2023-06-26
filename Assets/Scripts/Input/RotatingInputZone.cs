using UnityEngine;
using UnityEngine.EventSystems;

public class RotatingInputZone : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private RotatorZ _rotatorZ;
    [SerializeField] private RotatorY _rotatorY;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _rotatorZ.enabled = true;
        _rotatorY.enabled = true;
    }

    //private void Update()
    //{
    //    if (Input.GetKeyUp(KeyCode.Mouse0))
    //    {
    //        _rotatorZ.enabled = false;
    //        _rotatorY.enabled = false;
    //    }
    //}
}
