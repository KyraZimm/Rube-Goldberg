﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CameraScript cScript;
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cScript.target = ball.transform;
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 0, 0), ForceMode2D.Impulse);
        }
    }
}