using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorNumeros : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI numero1;
    public TextMeshProUGUI numero2;
    public TextMeshProUGUI numero3;
    public TextMeshProUGUI numero4;
    public TextMeshProUGUI numOperacion1;
    public TextMeshProUGUI numOperacion2;
     public GameObject num1,num2,num3,correcto, slotCorrecto;
     Vector2 num1InitialPos,num2InitialPos,num3InitialPos, correctoInitialPos;

    int n;
    int n2;
    int n3;
    int n4;
    int nOp1;
    int nOp2;
    void Start()
    {
         n = Random.Range(0,10);
         numero1.text = n.ToString();
         
          n3 = Random.Range(0,10);
         numero3.text = n3.ToString();
          n4 = Random.Range(0,10);
         numero4.text = n4.ToString();
          nOp1 = Random.Range(0,10);
         numOperacion1.text = nOp1.ToString();
         nOp2 = Random.Range(0,10);
         numOperacion2.text = nOp2.ToString();
          n2 = (nOp1 + nOp2);
         numero2.text = n2.ToString();
         num1InitialPos = num1.transform.position;
         num2InitialPos = num2.transform.position;
         num3InitialPos = num3.transform.position;
         correctoInitialPos = correcto.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void DragNumero1(){
        num1.transform.position = Input.mousePosition;

    }
    public void DragNumero2(){
        num2.transform.position = Input.mousePosition;

    }
    public void DragNumero3(){
        num3.transform.position = Input.mousePosition;

    }
    public void DragCorrecto(){
        correcto.transform.position = Input.mousePosition;

    }
    public void DropCorrecto(){
        float distancia = Vector3.Distance(correcto.transform.position, slotCorrecto.transform.position);
        if(distancia < 50){
            correcto.transform.position = slotCorrecto.transform.position;
           
        }
        else{
             
            correcto.transform.position = correctoInitialPos;
        }

    }
    public void DropNumero1(){
       
        
            num1.transform.position = num1InitialPos;
        

    }
    public void DropNumero2(){
       
        
            num2.transform.position = num2InitialPos;
        

    }
    public void DropNumero3(){
       
        
            num3.transform.position = num3InitialPos;
        

    }
}
