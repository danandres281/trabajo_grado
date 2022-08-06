using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeteccionObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Collider2D> listaObjetos = new List<Collider2D>();
    public GameObject fruta;
    //public Text textoCantidad1;
    private int cantidad = 0;
    public TextMeshProUGUI textoCantidad1;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        textoCantidad1.text = listaObjetos.Count.ToString();
        if(listaObjetos.Count == 0){
            textoCantidad1.text = "";
        }
        
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
}
