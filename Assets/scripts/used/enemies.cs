using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemies : MonoBehaviour
{
   public float health =100f;
    scenechange s;
    private void Start()
    {
        s = GetComponent<scenechange>();
    }
    public void edamage(float amt){
    health -=amt;
    if(health <=0f){
        edie();

    }
   }
   void edie(){
    Destroy(gameObject);
        s.n--;
        Debug.Log("---------------------->" + s.n);
        
   }
    void win()
    {
        SceneManager.LoadScene("WINend");
    }

   
}
