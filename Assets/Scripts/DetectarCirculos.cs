using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarCirculos : MonoBehaviour
{
    RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
    public GameObject circulo;
    public GameObject correcto;
    public GameObject instrucciones;
    public GameObject incorrecto;
     public GameObject menuCuadrado;
      public GameObject menuTriangulo;
    public GameObject  menuFinal;
     public GameObject menuCirculo;
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
        if(circulo.tag == "circulo" && menuCuadrado.activeSelf == false && menuTriangulo.activeSelf == false && menuCirculo.activeSelf == true){
            correcto.SetActive(true);
            instrucciones.SetActive(false);
            StartCoroutine(AparecerMenuFinal(menuFinal));
            StartCoroutine(DesaparecerMenuCorrecto(correcto));
        }
        else{
            StartCoroutine(DesaparecerMenuIncorrecto(incorrecto));
        }

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
    public IEnumerator AparecerMenuFinal(GameObject incorrecto){
        
        yield return new WaitForSecondsRealtime(3);
        menuFinal.SetActive(true);
        
    }
}
