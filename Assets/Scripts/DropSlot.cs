using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour , IDropHandler
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }
      public void OnDrop(PointerEventData data)
    {
        if(!item){
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(item != null && item.transform.parent != transform){
            item = null;

        }
        
    }
   
}
