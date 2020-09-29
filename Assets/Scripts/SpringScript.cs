using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    private bool collided = false;
    
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
        if (col.gameObject.tag != "Ball")
        {
            if (collided == false)
            {
                gameObject.GetComponent<SpringJoint2D>().distance = 10;
                collided = true;
            }
        }
    }
}
