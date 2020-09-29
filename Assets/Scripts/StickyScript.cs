using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript : MonoBehaviour
{
    private bool ballStick = false;
    
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

        if (col.gameObject.tag == "Ball")
        {
            if (ballStick == false)
            {
                gameObject.GetComponent<FrictionJoint2D>().connectedBody = col.gameObject.GetComponent<Rigidbody2D>();
                ballStick = true;
            }
        }
    }
}
