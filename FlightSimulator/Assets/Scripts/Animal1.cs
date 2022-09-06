using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal1 : Creature
{
    // Start is called before the first frame upda
    
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        speed = 5.0f;
        turnSpeed = 25.0f;
        MainCamera = GameObject.FindGameObjectsWithTag("Player")[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        ForwardsBackwards(forwardInput);
        horizontalInput = Input.GetAxis("Horizontal");
        TurnRightLeft(horizontalInput);
    }
}
