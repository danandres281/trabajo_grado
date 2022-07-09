using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    
    // Start is called before the first frame update
    public static GameObject itemDragging;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }
    public void OnDrag(PointerEventData data)
    {
        Debug.Log("Ondrag");
        transform.position = Input.mousePosition;
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
