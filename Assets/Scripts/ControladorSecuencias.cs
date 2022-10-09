using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSecuencias : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imagen1,imagen2,imagen3,imagen4,slotImagen1,slotImagen2,slotImagen3,slotImagen4;
     Vector2 imagen1InitialPos,imagen2InitialPos,imagen3InitialPos,imagen4InitialPos;
     private ArrayList secuencias;
     public GameObject finJuego;
     public GameObject uno;
     public GameObject dos;
     public GameObject tres;
     public GameObject cuatro;
     //private Array<GameObject> secuencias;
    void Start()
    {
        secuencias = new ArrayList();
        imagen1InitialPos = imagen1.transform.position;
        imagen2InitialPos = imagen2.transform.position;
        imagen3InitialPos = imagen3.transform.position;
        imagen4InitialPos = imagen4.transform.position;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(secuencias.Count >= 4){
            StartCoroutine(FinalizarJuego(finJuego));
            
        }
    }
    public IEnumerator FinalizarJuego(GameObject finJuego){
        yield return new WaitForSecondsRealtime(1);
        finJuego.SetActive(true);
        finJuego.SetActive(true);
            imagen1.SetActive(false);
            imagen2.SetActive(false);
            imagen3.SetActive(false);
            imagen4.SetActive(false);
            slotImagen1.SetActive(false);
            slotImagen2.SetActive(false);
            slotImagen3.SetActive(false);
            slotImagen4.SetActive(false);
            uno.SetActive(false);
        dos.SetActive(false);
        tres.SetActive(false);
        cuatro.SetActive(false);
    }
    public void DragImagen1(){
        imagen1.transform.position = Input.mousePosition;

    }
    public void DragImagen2(){
        imagen2.transform.position = Input.mousePosition;

    }
    public void DragImagen3(){
        imagen3.transform.position = Input.mousePosition;

    }
    public void DragImagen4(){
        imagen4.transform.position = Input.mousePosition;

    }

    public void DropImagen1(){
        float distancia = Vector3.Distance(imagen1.transform.position, slotImagen1.transform.position);
        if(distancia < 50){
            imagen1.transform.position = slotImagen1.transform.position;
            secuencias.Add("secuencia1");
            //correcto.Play();
           
        }
        else{
             
            imagen1.transform.position = imagen1InitialPos;
            //incorrecto.Play();
        }

    }
    public void DropImagen2(){
        float distancia = Vector3.Distance(imagen2.transform.position, slotImagen2.transform.position);
        if(distancia < 50){
            imagen2.transform.position = slotImagen2.transform.position;
            secuencias.Add("secuencia2");
            //correcto.Play();
           
        }
        else{
             
            imagen2.transform.position = imagen2InitialPos;
            //incorrecto.Play();
        }

    }
    public void DropImagen3(){
        float distancia = Vector3.Distance(imagen3.transform.position, slotImagen3.transform.position);
        if(distancia < 50){
            imagen3.transform.position = slotImagen3.transform.position;
            secuencias.Add("secuencia3");
            //correcto.Play();
           
        }
        else{
             
            imagen3.transform.position = imagen3InitialPos;
            //incorrecto.Play();
        }

    }
    public void DropImagen4(){
        float distancia = Vector3.Distance(imagen4.transform.position, slotImagen4.transform.position);
        if(distancia < 50){
            imagen4.transform.position = slotImagen4.transform.position;
            secuencias.Add("secuencia3");
            //correcto.Play();
           
        }
        else{
             
            imagen4.transform.position = imagen4InitialPos;
            //incorrecto.Play();
        }

    }
}
