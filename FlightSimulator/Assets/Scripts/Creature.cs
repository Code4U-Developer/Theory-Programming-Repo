using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    // INHERITANCE
    protected float speed;
    protected float turnSpeed; 

    protected GameObject MainCamera;

    // ABSTRACTION
    public virtual void ForwardsBackwards(float forwardInput){
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        CameraTracking();
    }

    // ABSTRACTION
    protected void CameraTracking(){
        MainCamera.transform.position = transform.position;
        MainCamera.transform.rotation = transform.rotation;
    }

    // ABSTRACTION
    protected void TurnRightLeft(float horizontalInput){
        transform.Rotate(Vector3.up, turnSpeed *  horizontalInput * Time.deltaTime);
    }
}
