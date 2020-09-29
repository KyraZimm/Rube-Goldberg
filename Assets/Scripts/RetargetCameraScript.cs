using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetargetCameraScript : MonoBehaviour
{
    public CameraScript cScript;
    public GameObject retarget;
    private bool retargeted = false;
    
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
            if (retargeted == false)
            {
                cScript.target = retarget.transform;
                retargeted = true;
            }
    }
}
