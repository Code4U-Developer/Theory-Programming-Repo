using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal3 : Creature
{
    // INHERITANCE
    
    private float horizontalInput;
    private float forwardInput;
    private float upJump = 11.5f;
    private Rigidbody AnRb;
    private float waitBetweenJump = 2;

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
        CameraTracking();
        if(waitBetweenJump >= 0){
        waitBetweenJump -= Time.deltaTime;
        }
    }

    // POLYMORPHISM
    public override void ForwardsBackwards(float forwardInput){
        if(forwardInput > 0){
        if(waitBetweenJump < 0){ 
        Jump();
        waitBetweenJump = 2;
        }
        }
    }

    void Jump(){
        AnRb.AddRelativeForce(new Vector3(0,1,1)* upJump/2, ForceMode.Impulse);
    }
}
