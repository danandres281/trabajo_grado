using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
    bool isDrag;
    void Start()
    {
        isDrag = false;
        cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            hit = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));
            if( hit.collider.tag == "fruta"){
                focus = hit.transform;
                Debug.Log("Es fruta");
                isDrag = true;
            }
        }
        else if(Input.GetMouseButtonUp(0) && isDrag == true){
            isDrag = false;
        }
        else if(isDrag == true){
            mousePos = Input.mousePosition;
            mousePos.z = -cam.transform.position.z;
            pos = cam.ScreenToWorldPoint(mousePos);
            focus.position = new Vector3(pos.x, pos.y, focus.position.z);
        }
        
    }
}
