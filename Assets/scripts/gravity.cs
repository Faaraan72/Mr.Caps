using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private GameObject go;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        go = GetComponent<GameObject>();

    }
  float g = 10f;
    public void gravityforce()
    {
        rb.velocity = new Vector3(0, -g, 0);
        Debug.Log("working");
    }
   
}
