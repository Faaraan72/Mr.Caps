using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class shootingpro : MonoBehaviour
{ public AudioSource a;
   public GameObject projectile;
   public float launchVelocity = 700f;
 
   void Update()
   {
       if (Input.GetButtonDown("Fire1"))
       { a.Play();
           GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
           ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0,launchVelocity,0));
              Destroy(ball,1f);
       }
   }
}