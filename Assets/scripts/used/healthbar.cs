﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform bar =transform.Find("Bar");
        bar.localScale = new Vector3(0.4f , 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
