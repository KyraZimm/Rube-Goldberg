using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3Script : MonoBehaviour
{

    public CameraScript cScript;
    public GameObject ball3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BallMover")
        {
            cScript.target = ball3.transform;
        }
    }
}
