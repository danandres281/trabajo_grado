using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMemorizar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uno,dos,tres,cuatro,cinco,unoJugable,dosJugable,tresJugable,cuatroJugable,cincoJugable,slot1,slot2,slot3,slot4,slot5;
     Vector2 unoInitialPos,dosInitialPos,tresInitialPos,cuatroInitialPos, cincoInitialPos;
    void Start()
    {
        unoInitialPos = unoJugable.transform.position;
         dosInitialPos = dosJugable.transform.position;
          tresInitialPos = tresJugable.transform.position;
           cuatroInitialPos = cuatroJugable.transform.position;
            cincoInitialPos = cincoJugable.transform.position;

        StartCoroutine(DesaparecerUno(uno));
        StartCoroutine(DesaparecerDos(dos));
        StartCoroutine(DesaparecerTres(tres));
        StartCoroutine(DesaparecerCuatro(cuatro));
        StartCoroutine(DesaparecerCinco(cinco));
        StartCoroutine(AparecerUno(unoJugable));
        StartCoroutine(AparecerSlots(slot1,slot2,slot3,slot4,slot5));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DragUno(){
        unoJugable.transform.position = Input.mousePosition;

    }
     public void DragDos(){
        dosJugable.transform.position = Input.mousePosition;

    }
     public void DragTres(){
        tresJugable.transform.position = Input.mousePosition;

    }
     public void DragCuatro(){
        cuatroJugable.transform.position = Input.mousePosition;

    }
     public void DragCinco(){
        cincoJugable.transform.position = Input.mousePosition;

    }
    public void DropUno(){
        float distancia = Vector3.Distance(unoJugable.transform.position, slot2.transform.position);
        if(distancia < 50){
            unoJugable.transform.position = slot2.transform.position;
            dosJugable.SetActive(true);
           
        }
        else{
             
            unoJugable.transform.position = unoInitialPos;
        }

    }
    public void DropDos(){
        float distancia = Vector3.Distance(dosJugable.transform.position, slot5.transform.position);
        if(distancia < 50){
            dosJugable.transform.position = slot5.transform.position;
            tresJugable.SetActive(true);
           
        }
        else{
             
            dosJugable.transform.position = dosInitialPos;
        }

    }
    public void DropTres(){
        float distancia = Vector3.Distance(tresJugable.transform.position, slot1.transform.position);
        if(distancia < 50){
            tresJugable.transform.position = slot1.transform.position;
            cuatroJugable.SetActive(true);
           
        }
        else{
             
            tresJugable.transform.position = tresInitialPos;
        }

    }
    public void DropCuatro(){
        float distancia = Vector3.Distance(cuatroJugable.transform.position, slot4.transform.position);
        if(distancia < 50){
            cuatroJugable.transform.position = slot4.transform.position;
            cincoJugable.SetActive(true);
           
        }
        else{
             
            cuatroJugable.transform.position = cuatroInitialPos;
        }

    }
    public void DropCinco(){
        float distancia = Vector3.Distance(cincoJugable.transform.position, slot3.transform.position);
        if(distancia < 50){
            cincoJugable.transform.position = slot3.transform.position;
           
        }
        else{
             
            cincoJugable.transform.position = cincoInitialPos;
        }

    }

    public IEnumerator DesaparecerUno(GameObject uno){
        yield return new WaitForSecondsRealtime(1);
        uno.SetActive(false);
    }
    public IEnumerator DesaparecerDos(GameObject dos){
        yield return new WaitForSecondsRealtime(2);
        dos.SetActive(false);
    }
    public IEnumerator DesaparecerTres(GameObject tres){
        yield return new WaitForSecondsRealtime(3);
        tres.SetActive(false);
    }
    public IEnumerator DesaparecerCuatro(GameObject cuatro){
        yield return new WaitForSecondsRealtime(4);
        cuatro.SetActive(false);
    }
    public IEnumerator DesaparecerCinco(GameObject cinco){
        yield return new WaitForSecondsRealtime(5);
        cinco.SetActive(false);
    }
    public IEnumerator AparecerUno(GameObject unoJugable){
        yield return new WaitForSecondsRealtime(6);
        unoJugable.SetActive(true);
    }
    public IEnumerator AparecerSlots(GameObject slot1,GameObject slot2, GameObject slot3, GameObject slot4, GameObject slot5){
        yield return new WaitForSecondsRealtime(6);
        slot1.SetActive(true);
        slot2.SetActive(true);
        slot3.SetActive(true);
        slot4.SetActive(true);
        slot5.SetActive(true);
    }
}
