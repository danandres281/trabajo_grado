using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour , IDropHandler
{
    public GameObject item;
    public GameObject cuadrado;
    public GameObject triangulo;
    public GameObject circulo;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public IEnumerator AparecerTriangulo(GameObject triangulo){
        yield return new WaitForSecondsRealtime(3);
        triangulo.SetActive(true);
    }
     public IEnumerator DesaparecerCuadrado(GameObject cuadrado){
        yield return new WaitForSecondsRealtime(3);
        cuadrado.SetActive(false);
    }
      public void OnDrop(PointerEventData data)
    {
        if(!cuadrado && !item){
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            
            StartCoroutine(AparecerTriangulo(triangulo));
            StartCoroutine(DesaparecerCuadrado(item));
            Debug.Log(item.name);
            
        } 
        /*else if(!triangulo && !item ){
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

        }*/
    }
   
    // Update is called once per frame
    void Update()
    {
        if(item != null && item.transform.parent != transform){
            item = null;

        }
        
    }
   
}
