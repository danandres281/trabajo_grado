using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ControladorSimbolos : MonoBehaviour
{
    public GameObject suma, resta, slotSuma,slotResta;
    Vector2 sumaInitialPosition,restaInitialPosition;
    public GameObject informacion;
    public GameObject finJuego;
    public TextMeshProUGUI numero1;
    public TextMeshProUGUI numero2;
    public TextMeshProUGUI numero3;
    public TextMeshProUGUI numero4;
    public TextMeshProUGUI resultado;
    public TextMeshProUGUI resultado2;
     private ArrayList simbolos;
    int n; 
    int n2;
    int n3;
    int n4;
    // Start is called before the first frame update
    void Start()
    {
        simbolos = new ArrayList();
        sumaInitialPosition = suma.transform.position;
        restaInitialPosition = resta.transform.position;
        n = Random.Range(0,10);
        n2 = Random.Range(0,10);
        n3 = Random.Range(0,10);
        n4 = Random.Range(0,9);
        numero1.text = n.ToString();
        numero2.text = n2.ToString();
         numero3.text = n3.ToString();
          numero4.text = n4.ToString();
        int operacion;
        int operacion2;
        Debug.Log(suma);
        /*if(n > n2){
               operacion = operacionResta(n,n2);
        }*/
        operacion = operacionSuma(n,n2);
        operacion2 = operacionResta(n3,n4);
        
        resultado.text = operacion.ToString();
        resultado2.text = operacion2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(simbolos.Count >= 2){
            StartCoroutine(FinalizarJuego(finJuego));
            
        }
        
    }
    public IEnumerator FinalizarJuego(GameObject finJuego){
        yield return new WaitForSecondsRealtime(1);
        finJuego.SetActive(true);
    }
    public int operacionSuma(int n1, int n2){
        return (n1 + n2);
    }
    public int operacionResta(int n1, int n2){
        return (n1 - n2);
    }

    public void DragSuma(){
        suma.transform.position = Input.mousePosition;

    }
    public void DragResta(){
        resta.transform.position = Input.mousePosition;

    }
     public void DropSuma(){
        float distancia = Vector3.Distance(suma.transform.position, slotSuma.transform.position);
         float distancia2 = Vector3.Distance(resta.transform.position, slotSuma.transform.position);
        if(distancia < 50  ){
            suma.transform.position = slotSuma.transform.position;
            slotSuma.SetActive(false);
           simbolos.Add("suma");
        }
        else{
             
            suma.transform.position = sumaInitialPosition;
             //resta.transform.position = slotSuma.transform.position;
            //incorrecto.Play();
        }

    }

     public void DropResta(){
        float distancia = Vector3.Distance(resta.transform.position, slotResta.transform.position);
        if(distancia < 50 ){
            resta.transform.position = slotResta.transform.position;
            slotResta.SetActive(false);
             simbolos.Add("resta");
           
        }
        else{
             
            resta.transform.position = restaInitialPosition;
            //incorrecto.Play();
        }

    }
}
