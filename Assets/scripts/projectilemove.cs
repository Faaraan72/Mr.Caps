using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilemove : MonoBehaviour
{
    public float speed;
    public float firerate;
    public GameObject projectile;
    public Camera cam;
    public Transform firepoint;
    private Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            shootpro();
        }
    }
    void shootpro(){
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)){
            destination = hit.point;
        }else{
            destination = ray.GetPoint(500);
        }
        Instantiatepro();
}
void Instantiatepro(){
    var pro =Instantiate (projectile, firepoint.position,Quaternion.identity) as GameObject;
    pro.GetComponent<Rigidbody>().velocity=(destination).normalized *speed;//-firepoint.position
    Destroy(pro,1f);
}
}
