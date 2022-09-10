using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarTriangulo : MonoBehaviour
{

     RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
    public GameObject triangulo;
    public GameObject correcto;
    public GameObject instrucciones;
    public GameObject incorrecto;
    public GameObject  menuCuadrado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0)){
            hit = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));
            if( hit.collider.tag == "triangulo"){
                //focus = hit.transform;
                Debug.Log("Es un triangulo con tag");
                
            }
        }*/
        
    }
    private void OnMouseDown(){
        if(triangulo.tag == "triangulo"){
            Debug.Log(" siiii Es un triangulo");
            correcto.SetActive(true);
            instrucciones.SetActive(false);
            StartCoroutine(AparecerMenuCuadrado(menuCuadrado));
            StartCoroutine(DesaparecerMenuCorrecto(correcto));
        }
        else{
            StartCoroutine(DesaparecerMenuIncorrecto(incorrecto));
        }
        Debug.Log("Es un triangulo");

    }
    public IEnumerator DesaparecerMenuIncorrecto(GameObject incorrecto){
        incorrecto.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        incorrecto.SetActive(false);
    }
    public IEnumerator DesaparecerMenuCorrecto(GameObject correcto){
        yield return new WaitForSecondsRealtime(2);
        correcto.SetActive(false);
    }
    public IEnumerator AparecerMenuCuadrado(GameObject incorrecto){
        
        yield return new WaitForSecondsRealtime(3);
        menuCuadrado.SetActive(true);
        
    }
}
