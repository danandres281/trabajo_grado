using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void jugar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void loadScene(string sceneName){
        SceneManager.LoadScene(sceneName);

    }
    public void loadRandomScene(){
        int index = Random.Range(14,16);
        SceneManager.LoadScene(index);
        Debug.Log(index);
    }
}
