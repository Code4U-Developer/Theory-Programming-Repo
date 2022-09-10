using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal2 : Creature
{
    // INHERITANCE
    
    private float horizontalInput;
    private float forwardInput;
    private float upJump = 8.5f;
    private float waitBetweenJump = 0;
    private Rigidbody AnRb;
    void Start()
    {
        speed = 15.0f;
        turnSpeed = 40.0f;
        AnRb = GetComponent<Rigidbody>();
        MainCamera = GameObject.FindGameObjectsWithTag("Player")[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        ForwardsBackwards(forwardInput);
        horizontalInput = Input.GetAxis("Horizontal");
        TurnRightLeft(horizontalInput);
        if(waitBetweenJump >= 0){
        waitBetweenJump -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            if(waitBetweenJump < 0){ 
            Jump();
            waitBetweenJump = 2;
            }
        }
    }

    void Jump(){
        AnRb.AddForce(Vector3.up * upJump, ForceMode.Impulse);
    }
}

