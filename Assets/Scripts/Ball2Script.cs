using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Script : MonoBehaviour
{
    public CameraScript cScript;
    public GameObject ball2;
    
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
        cScript.target = ball2.GetComponent<Transform>();
    }
}
