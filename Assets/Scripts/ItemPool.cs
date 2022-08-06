using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPool : MonoBehaviour  , IDropHandler
{

     public void OnDrop(PointerEventData data)
    {

        DragHandler.itemDragging.transform.SetParent(transform);
        
        
    }
    
   
}
