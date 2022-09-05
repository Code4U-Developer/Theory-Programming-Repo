using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void VehicleSelected(int selection){
       //Changes Data of the vehicle selected and changes scene
        GameManager.Instance.VehSelected = selection;
        SceneManager.LoadScene(1);
    }
    
}
