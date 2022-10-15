using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ControladorRestar : MonoBehaviour
{
    // Start is called before the first frame update
   public TextMeshProUGUI numero1;
    public TextMeshProUGUI numero2;
    public TextMeshProUGUI numero3;
    public TextMeshProUGUI numero4;
    public TextMeshProUGUI numOperacion1;
    public TextMeshProUGUI numOperacion2;
    public GameObject finJuego;
     public GameObject num1,num2,num3,correcto, slotCorrecto;
     Vector2 num1InitialPos,num2InitialPos,num3InitialPos, correctoInitialPos;
     private Vector3[] posiciones = {
        new Vector3(353f, 57.5f, 0.0f),
        new Vector3(630f, 57.5f, 0.0f),
        new Vector3(495f, 57.5f, 0.0f),
        new Vector3(198f, 57.5f, 0.0f),
    };
    private Vector3 tempPosition;
    int i;
    int n;
    int n2;
    int n3;
    int n4;
    int nOp1;
    int nOp2;
    int s;
    int d;
    void Start()
    {
         i = Random.Range(0, posiciones.Length);
         n = Random.Range(0,10);
         Debug.Log(num1.transform.position + " numero 1");
        Debug.Log(num2.transform.position + " numero 2");
        Debug.Log(num3.transform.position + " numero 3");
        Debug.Log(correcto.transform.position + " numero correcto");
         s = Random.Range(1,10);
          d = Random.Range(1,9);
          n3 = Random.Range(0,10);
         
          n4 = Random.Range(0,10);
          tempPosition = correcto.transform.position;
         correcto.transform.position = posiciones[i];
        
         if(correcto.transform.position == num1.transform.position){
           
            num1.transform.position = tempPosition;
         }
         if(correcto.transform.position == num2.transform.position){
            num2.transform.position = tempPosition;
         }
         if(correcto.transform.position == num3.transform.position){
           
            num3.transform.position = tempPosition;
         }
         
          nOp1 = Random.Range(0,10);
         numOperacion1.text = nOp1.ToString();
         nOp2 = Random.Range(0,10);
         numOperacion2.text = nOp2.ToString();
          n2 = (nOp1 - nOp2);
          if(n2 == n3){

            n3 = (n3 + s);
            Debug.Log(n3);
          }
          if(n2 == n4){
            n4 = (n4 + d);
          }
          if(n2 == n){
            n = (n4 + d);
          }
          numero4.text = n4.ToString();
          numero1.text = n.ToString();
         numero2.text = n2.ToString();
         numero3.text = n3.ToString();
         num1InitialPos = num1.transform.position;
         num2InitialPos = num2.transform.position;
         num3InitialPos = num3.transform.position;
         correctoInitialPos = correcto.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator FinalizarJuego(GameObject finJuego){
        yield return new WaitForSecondsRealtime(1);
        finJuego.SetActive(true);
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
           StartCoroutine(FinalizarJuego(finJuego));
           slotCorrecto.SetActive(false);
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
