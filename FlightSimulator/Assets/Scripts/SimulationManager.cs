using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;

public class SimulationManager : MonoBehaviour
{
    public GameObject[] Object;
    public TextMeshProUGUI instructionText;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.CreSelected == 0 || GameManager.Instance.CreSelected == 2){
            instructionText.text = "Use Your Arrows Keys to move Around!";
        }else{
            instructionText.text = "\nUse Your Arrows Keys to move Around! \nClick Space if you want to Jump!";
        }

        Instantiate(Object[GameManager.Instance.CreSelected],new Vector3(0,1,0), Object[GameManager.Instance.CreSelected].transform.rotation);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.X)){
            SceneManager.LoadScene(0);
        }
    }
}
