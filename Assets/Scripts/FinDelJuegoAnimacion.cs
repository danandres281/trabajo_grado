using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDelJuegoAnimacion : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform box;
   private void OnEnable(){
    box.LeanMoveLocalY(0 , 0.5f);
    box.localPosition = new Vector2(0 , -Screen.height);
    box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
   }
    void OnDisable(){
    box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
   }
}
