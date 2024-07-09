using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logic_Manager logic;
    public bool birdIsAlive = true;
    public float deadzone = -35;

    AudioManager AudioManager;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        //finding logic member in hierarchy
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Manager>();
    }

    void Update()
    {
        if (!PauseMenu.ispaused)
        {
            //logic making the bird jump
            if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
                AudioManager.PlaySFX(AudioManager.jump);

            }
        }
        //if bird goes out of bounds game is over
        if (transform.position.y < deadzone)
        {
            Debug.Log("Out of Bounds");
            logic.gameOver();
        }
    }

    //if bird hits the pipes game is over
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        AudioManager.PlaySFX(AudioManager.death);
    }
}
