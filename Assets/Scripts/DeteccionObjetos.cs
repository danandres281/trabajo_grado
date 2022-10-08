using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeteccionObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Collider2D> listaObjetos = new List<Collider2D>();
    public GameObject fruta;
    public TextMeshProUGUI numero;
    public GameObject finJuego;
    public GameObject incorrecto;
    //public Text textoCantidad1;
    private int cantidad = 0;
    int n;
    public TextMeshProUGUI textoCantidad1;
    void Start()
    {
        n = Random.Range(1,9);
        numero.text = n.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textoCantidad1.text = listaObjetos.Count.ToString();
        if(listaObjetos.Count == 0){
            textoCantidad1.text = "";
        }
        
        

        
    }
     public IEnumerator FinalizarJuego(GameObject finJuego){
        yield return new WaitForSecondsRealtime(1);
        finJuego.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Entro");
        if(col.gameObject.tag == "fruta"){
            listaObjetos.Add(col);
            Debug.Log("El contenedor tiene " + listaObjetos.Count + " frutas");
        }
        if(col.gameObject == fruta){
            Debug.Log("colision");
        }
        
    }
    void OnTriggerExit2D(Collider2D col){
        listaObjetos.Remove(col);
       
    }
     public IEnumerator AparecerMenuincorrecto(GameObject incorrecto){
        yield return new WaitForSecondsRealtime(2);
        incorrecto.SetActive(true);
    }

    public void finalizar(){
        if(textoCantidad1.text == numero.text){
            StartCoroutine(FinalizarJuego(finJuego));

        }
        else{
            StartCoroutine(AparecerMenuincorrecto(incorrecto));
        }
    }
}
