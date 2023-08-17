using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{

    public Animator anim;
    public float range =100f;
    public float damage =10f;
    public float gunthrust =30f;
    public float firerate =1f;

    public GameObject gun;
    public GameObject ImpactEffect;
    public GameObject Impactobj;

    private float nextfire=0f;


    public ParticleSystem  MuzzleFlash;
   
  
    // void start(){
    //     gun=GameObject.FindGameObjectWithTag(tag);
    // }
    // Update is called once per frame
    void Update()
    {
       
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));




          if (Input.GetButton("Jump"))
        {   
      anim.SetBool("jump", true);}
      if (Input.GetButtonUp("Jump"))
        {   
      anim.SetBool("jump", false);}
       




         
         if (Input.GetButton("Fire1") && Time.time >= nextfire) 
         {  nextfire =Time.time * 1f/firerate;
        anim.SetBool("shoot", true);
        shoot();
    }
     
     if (Input.GetButtonUp("Fire1"))
    {
        anim.SetBool("shoot", false);
    }
    void shoot(){
            MuzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(gun.transform.position , gun.transform.forward, out hit , range)){
            Debug.Log(hit.transform.name);
          enemy target=  hit.transform.GetComponent<enemy>();
          if(target != null){
            target.takedamage(damage);
            GameObject g= Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(g,2f);
          }
          if(hit.rigidbody != null){
            hit.rigidbody.AddForce(-hit.normal * gunthrust);
          }
           GameObject k= Instantiate(Impactobj, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(k,1f);
         
        }
        

    }
        
    }
}
