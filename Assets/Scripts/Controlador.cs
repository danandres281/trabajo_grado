using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject triangulo,cuadrado,circulo, slotCirculo, slotCuadrado, slotTriangulo, finJuego;
    public AudioSource correcto;
    public AudioSource incorrecto;
    public GameObject menuInformacion;
   public GameObject[] figuras;
   int n;
    private ArrayList numeros;
    
    //public GameObject finJuego;
    Vector2 trianguloInitialPos,cuadradoInitialPos,circuloInitialPos;
    void Start()
    {
        numeros = new ArrayList();
        n = Random.Range(0 , figuras.Length);
        trianguloInitialPos = triangulo.transform.position;
        cuadradoInitialPos = cuadrado.transform.position;
        circuloInitialPos = circulo.transform.position;
        finJuego.SetActive(false);
        StartCoroutine(DesaparecerMenuInformacion(menuInformacion));
        figuras[n].SetActive(true);
        
    }
    public IEnumerator AparecerTriangulo(GameObject triangulo){
        yield return new WaitForSecondsRealtime(2);
        triangulo.SetActive(true);
    }
    public IEnumerator AparecerCirculo(GameObject circulo){
        yield return new WaitForSecondsRealtime(2);
        circulo.SetActive(true);
    }
    public IEnumerator AparecerCuadrado(GameObject cuadrado){
        yield return new WaitForSecondsRealtime(2);
        cuadrado.SetActive(true);
    }
     public IEnumerator DesaparecerCuadrado(GameObject cuadrado){
        yield return new WaitForSecondsRealtime(2);
        cuadrado.SetActive(false);
    }
    public IEnumerator DesaparecerMenuInformacion(GameObject menuInformacion){
        yield return new WaitForSecondsRealtime(5);
        menuInformacion.SetActive(false);
    }
     public IEnumerator DesaparecerTriangulo(GameObject triangulo){
        yield return new WaitForSecondsRealtime(2);
        triangulo.SetActive(false);
    }
    public IEnumerator DesaparecerCirculo(GameObject circulo){
        yield return new WaitForSecondsRealtime(2);
        circulo.SetActive(false);
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
            correcto.Play();
           numeros.Add("triangulo");
             StartCoroutine(AparecerCirculo(circulo));
        StartCoroutine(DesaparecerTriangulo(triangulo));
        }
        else{
             
            triangulo.transform.position = trianguloInitialPos;
            incorrecto.Play();
        }

    }
    public void DropCuadrado(){
        float distancia = Vector3.Distance(cuadrado.transform.position, slotCuadrado.transform.position);
        if(distancia < 50){
            cuadrado.transform.position = slotCuadrado.transform.position;
            numeros.Add("cuadrado");
             correcto.Play();
            StartCoroutine(AparecerTriangulo(triangulo));
        StartCoroutine(DesaparecerCuadrado(cuadrado));
        }
        else{
            cuadrado.transform.position = cuadradoInitialPos;
             incorrecto.Play();
        }
        

    }
    public void DropCirculo(){
        float distancia = Vector3.Distance(circulo.transform.position, slotCirculo.transform.position);
        if(distancia < 50){
            circulo.transform.position = slotCirculo.transform.position;
             correcto.Play();
             StartCoroutine(DesaparecerCirculo(circulo));
             StartCoroutine(AparecerCuadrado(cuadrado));
             numeros.Add("circulo");
            //StartCoroutine(FinalizarJuego(finJuego));
            
            
        }
        else{
            circulo.transform.position = circuloInitialPos;
             incorrecto.Play();
        }

    }
    public void LoadScene(string scenename){
        SceneManager.LoadScene(scenename);
    }

    

    // Update is called once per frame
    void Update()
    {
        if(numeros.Count >= 3){
            StartCoroutine(FinalizarJuego(finJuego));
            StartCoroutine(DesaparecerSlotTriangulo(slotTriangulo));
            StartCoroutine(DesaparecerSlotCuadrado(slotCuadrado));
             StartCoroutine(DesaparecerTriangulo(triangulo));
              StartCoroutine(DesaparecerCuadrado(cuadrado));
               StartCoroutine(DesaparecerCirculo(circulo));
        }
    }
}
