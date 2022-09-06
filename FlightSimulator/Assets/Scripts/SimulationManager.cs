using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public GameObject[] Object;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Object[GameManager.Instance.CreSelected],new Vector3(0,1,0), Object[GameManager.Instance.CreSelected].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameManager.Instance.simulatorRunning = true;
        }   
    }
}
