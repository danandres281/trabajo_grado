using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarCuadrado : MonoBehaviour
{

     RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
    public GameObject cuadrado;
    public GameObject correcto;
    public GameObject instrucciones;
    public GameObject incorrecto;
    public GameObject  menuCirculo;
    public GameObject  menuTriangulo;
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("Script cuadrado");
         Debug.Log(cuadrado.tag);
         
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
        Debug.Log("es un cuadrado");
        if(cuadrado.tag == "cuadrado" && menuTriangulo.activeSelf == false && menuCirculo.activeSelf == false){
            Debug.Log("es un cuadrado");
            correcto.SetActive(true);
            instrucciones.SetActive(false);
            StartCoroutine(AparecerMenuCirculo(menuCirculo));
            StartCoroutine(DesaparecerMenuCorrecto(correcto));
        }
        else{
            StartCoroutine(DesaparecerMenuIncorrecto(incorrecto));
        }
        Debug.Log("Es un cuadrado");

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
    public IEnumerator AparecerMenuCirculo(GameObject incorrecto){
        
        yield return new WaitForSecondsRealtime(3);
        menuCirculo.SetActive(true);
        
    }
}
