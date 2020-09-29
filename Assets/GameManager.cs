using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public CameraScript cScript;
    public GameObject ball;
    public Text instructText;
    
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
            instructText.text = " ";
        }
    }
}
