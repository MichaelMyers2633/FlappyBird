using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

   
    void Start()
    {
        spawnPipe();
    }

   
    void Update()
    {
        //making the pipes spawn at a smooth rate
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        
    }

    //pipes spawn at different heights
    void spawnPipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;

        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }

}
