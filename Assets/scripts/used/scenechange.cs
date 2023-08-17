using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class scenechange: MonoBehaviour {  
    public int n = 6;
    private void Update()
    {
        if (n == 0)
        {
            Debug.Log("scenechange lost!-------------->"+n);
        }
    }
    public void Scene1() {  
        SceneManager.LoadScene("Scene1");  
    }
    public void Scenestarting()
    {
        SceneManager.LoadScene("start");
    }
    public void quit()
    {
        Application.Quit();
    }

}  
