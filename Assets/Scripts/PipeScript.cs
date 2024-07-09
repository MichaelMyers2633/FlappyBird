using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public float movespeed = 5;
    public float deadzone = -35;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        //making pipes move left across the scene
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        //destroying the pipe to create memory space
        if(transform.position.x < deadzone)
        {
            Debug.Log("Destroyed Pipe!");
            Destroy(gameObject);
        }
    }
}
