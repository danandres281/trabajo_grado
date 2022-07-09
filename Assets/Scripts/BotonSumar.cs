using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonSumar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pastel1;
    public GameObject pastel2;
    public GameObject pastel3;
    public GameObject pastel4;
    public GameObject pastel5;
    public GameObject pastel6;
    public GameObject pastel7;
    public Text textoCantidad1;
    public Text textoCantidad2;
    public Text resultado;
    //private Vector3 iniPosicion = pastel1.transform.position;
    
    void Start()
    {
        //Debug.Log(iniPosicion.x);
         //pastel1 = GameObject.FindGameObjectWithTag("pastel1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sumar(){
        
        pastel1.transform.position = new Vector2(-1.29f,0.066f);
        pastel2.transform.position = new Vector2(-1.22f,0.057f);
         pastel3.transform.position = new Vector2(-1.31f,-0.0097f);
          pastel4.transform.position = new Vector2(-1.13f,0.062f);
           pastel5.transform.position = new Vector2(-1.05f,0.014f);
            pastel6.transform.position = new Vector2(-1.14f,-0.0097f);
             pastel7.transform.position = new Vector2(-1.23f,-0.010f);
             textoCantidad1.text = "";
             textoCantidad2.text = "";
             resultado.text = "7";
         
        
    }
}
