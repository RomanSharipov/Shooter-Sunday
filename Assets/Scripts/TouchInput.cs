using UnityEngine;
using UnityEngine.EventSystems;

public class TouchInput : MonoBehaviour, IDragHandler,IPointerDownHandler  
{
    [SerializeField] private Vector2 _direction;
    public Vector2 Direction => _direction;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _direction = Vector2.zero;
    }

    private void Update()
    {
        Debug.Log($"Direction= {Direction}");
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            Vector2 dragDelta = eventData.delta / Screen.width;
            _direction.x = dragDelta.x;
            _direction.y = dragDelta.y;
        }
    }
}
