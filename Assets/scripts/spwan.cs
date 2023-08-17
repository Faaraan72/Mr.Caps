using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject firepoint;
    // public mouselook mouselook;
    

    public List<GameObject> e= new List<GameObject>();
        

    private GameObject effecttospawn;
    // Start is called before the first frame update
    void Start()
    {
        effecttospawn =e[0];
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Fire1")){
            Spwanvfx();
        }
        
    }
    void Spwanvfx(){
        GameObject Vfx;
        if(firepoint!=null){
            Vfx = Instantiate(effecttospawn, firepoint.transform.position , Quaternion.identity);
    }
}}
