using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{   public float range =100f;
    public float damage =10f;
    public float gunthrust =30f;
    public float firerate =1f;


    public GameObject gun;
    public GameObject ImpactEffect;
    public GameObject Impactobj;
    public ParticleSystem MuzzleFlash;
    public float speed;
    


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Fire1")){
            shooting();
         }
        
}
  public void shooting(){
            MuzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(gun.transform.position , gun.transform.forward, out hit , range)){
            Debug.Log(hit.transform.name);
            
          enemy target=  hit.transform.GetComponent<enemy>();
          if(target != null){
            target.takedamage(damage);
            GameObject g= Instantiate(ImpactEffect, hit.point,Quaternion.LookRotation(hit.normal));
            Destroy(g,2f);
          }
          if(hit.rigidbody != null){
            hit.rigidbody.AddForce(-hit.normal * gunthrust);
          }
           GameObject k= Instantiate(Impactobj, hit.point,Quaternion.LookRotation(hit.normal));//
            Destroy(k,1f);
         
        }
    }
}