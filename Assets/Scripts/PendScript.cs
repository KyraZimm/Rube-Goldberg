using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendScript : MonoBehaviour
{
    private bool ballStick = false;
    public List<Rigidbody2D> joints;
    
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
        if (ballStick == false)
        {
            gameObject.GetComponent<FrictionJoint2D>().connectedBody = col.gameObject.GetComponent<Rigidbody2D>();
            for(int i = 0; i < joints.Count; i++)
            {
                joints[i].bodyType = RigidbodyType2D.Dynamic;
            }

            ballStick = true;
        }
    }
}
