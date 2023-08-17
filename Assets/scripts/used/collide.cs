using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{  
//    public float phealth;
//    public float ehealth;
   public float damage;
   enemies e ;//enemy target=  hit.transform.GetComponent<enemy>();
   playerdie p;
   
    void OnCollisionEnter(Collision c){
        // Debug.Log(c.gameObject.tag);
      
   
      e = c.gameObject.GetComponent<enemies>();
      p = c.gameObject.GetComponent<playerdie>();
     if(c.gameObject.tag =="player1"){
        p.takedamage(damage);
        Debug.Log(p.health);
     }
     if(c.gameObject.tag =="agent"){
        e.edamage(damage);
        //Debug.Log(e.health);


        }
   }
}
