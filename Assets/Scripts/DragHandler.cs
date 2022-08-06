using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    
    Vector3 posicionInicial;
    Transform startParent;
    Transform dragParent;
    public static GameObject itemDragging;
    private CanvasGroup canvasGroup;
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    void Update()
    {
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemDragging = gameObject;
        posicionInicial = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = .6f;
        
    }
    public void OnDrag(PointerEventData data)
    {
        transform.position = Input.mousePosition;
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        itemDragging = null;
        if(transform.parent == dragParent){
            transform.position = posicionInicial;
            transform.SetParent(startParent);
        }
        canvasGroup.blocksRaycasts = true;
         canvasGroup.alpha = 1f;
        
    }
}
