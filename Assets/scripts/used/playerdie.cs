using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdie : MonoBehaviour
{
   public float health =150f;
    public bool pdie = false;
    FirstPersonController fp;
    private void Start()
    {
        fp = GetComponent<FirstPersonController>();
    }
    public void takedamage(float amt){
    health -=amt;
    if(health <=0f){
        die();

    }
   }
   void die(){
    pdie =true;
        fp.playerCanMove = false;
    Cursor.lockState = CursorLockMode.None;
        Invoke(nameof(lost), 1f);
    
   }
    void lost()
    {
        SceneManager.LoadScene("LOSTend");
    }

   
}
//  public void Scene1() {  
//         SceneManager.LoadScene("Scene1");  
//     }  
//     public void Scene2() {  
//         SceneManager.LoadScene("Scene2");  
//     }  
//     public void Scene3() {  
//         SceneManager.LoadScene("Scene3");  
//     } 