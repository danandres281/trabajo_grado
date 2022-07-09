using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonRestar : MonoBehaviour
{
    public GameObject galleta1;
    public GameObject galleta2;
    public GameObject galleta3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restar(){
        /*galleta1.SetActive(false);
        galleta2.SetActive(false);
        galleta3.SetActive(false);*/
         StartCoroutine(ComerGalletas());
    }
    public IEnumerator ComerGalletas(){
        yield return new WaitForSecondsRealtime(1f);
        galleta1.SetActive(false);
        galleta2.SetActive(false);
        galleta3.SetActive(false);
    }

}
