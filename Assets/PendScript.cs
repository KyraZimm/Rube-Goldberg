using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendScript : MonoBehaviour
{
    public List<GameObject> joints;
    
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
        for (int i = 0; i < joints.Count - 1; i++)
        {
            SpringJoint2D newSpring = joints[i].AddComponent<SpringJoint2D>();
            newSpring.anchor = new Vector2(0, 0);
            newSpring.connectedAnchor = joints[i + 1].transform.position;
        }
    }
}
