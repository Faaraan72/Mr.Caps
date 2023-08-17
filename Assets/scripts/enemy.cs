using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   public float health =100f;

   public void takedamage(float amt){
    health -=amt;
    if(health <=0f){
        die();

    }
   }
   void die(){
    Destroy(gameObject);
   }

   
}
