using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject triangulo,cuadrado,circulo, slotCirculo, slotCuadrado, slotTriangulo, finJuego;
    //public GameObject finJuego;
    Vector2 trianguloInitialPos,cuadradoInitialPos,circuloInitialPos;
    void Start()
    {
        trianguloInitialPos = triangulo.transform.position;
        cuadradoInitialPos = cuadrado.transform.position;
        circuloInitialPos = circulo.transform.position;
        finJuego.SetActive(false);
        
    }
    public IEnumerator AparecerTriangulo(GameObject triangulo){
        yield return new WaitForSecondsRealtime(2);
        triangulo.SetActive(true);
    }
    public IEnumerator AparecerCirculo(GameObject circulo){
        yield return new WaitForSecondsRealtime(2);
        circulo.SetActive(true);
    }
     public IEnumerator DesaparecerCuadrado(GameObject cuadrado){
        yield return new WaitForSecondsRealtime(2);
        cuadrado.SetActive(false);
    }
     public IEnumerator DesaparecerTriangulo(GameObject triangulo){
        yield return new WaitForSecondsRealtime(2);
        triangulo.SetActive(false);
    }
    public IEnumerator FinalizarJuego(GameObject finJuego){
        yield return new WaitForSecondsRealtime(2);
        finJuego.SetActive(true);
    }
     public IEnumerator DesaparecerSlotTriangulo(GameObject slotTriangulo){
        yield return new WaitForSecondsRealtime(2);
        slotTriangulo.SetActive(false);
    }
    public IEnumerator DesaparecerSlotCuadrado(GameObject slotCuadrado){
        yield return new WaitForSecondsRealtime(2);
        slotCuadrado.SetActive(false);
    }
    public void DragTriangulo(){
        triangulo.transform.position = Input.mousePosition;

    }
    public void DragCuadrado(){
        cuadrado.transform.position = Input.mousePosition;
        
         
    }
    public void DragCirculo(){
        circulo.transform.position = Input.mousePosition;

    }
    public void DropTriangulo(){
        float distancia = Vector3.Distance(triangulo.transform.position, slotTriangulo.transform.position);
        if(distancia < 50){
            triangulo.transform.position = slotTriangulo.transform.position;
             StartCoroutine(AparecerCirculo(circulo));
        StartCoroutine(DesaparecerTriangulo(triangulo));
        }
        else{
            triangulo.transform.position = trianguloInitialPos;
        }

    }
    public void DropCuadrado(){
        float distancia = Vector3.Distance(cuadrado.transform.position, slotCuadrado.transform.position);
        if(distancia < 50){
            cuadrado.transform.position = slotCuadrado.transform.position;
            StartCoroutine(AparecerTriangulo(triangulo));
        StartCoroutine(DesaparecerCuadrado(cuadrado));
        }
        else{
            cuadrado.transform.position = cuadradoInitialPos;
        }
        

    }
    public void DropCirculo(){
        float distancia = Vector3.Distance(circulo.transform.position, slotCirculo.transform.position);
        if(distancia < 50){
            circulo.transform.position = slotCirculo.transform.position;
            StartCoroutine(FinalizarJuego(finJuego));
            StartCoroutine(DesaparecerSlotTriangulo(slotTriangulo));
            StartCoroutine(DesaparecerSlotCuadrado(slotCuadrado));
            
        }
        else{
            circulo.transform.position = circuloInitialPos;
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
