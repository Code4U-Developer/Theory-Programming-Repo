using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void CreatureSelected(int selection){
       //Changes Data of the vehicle selected and changes scene
        GameManager.Instance.CreSelected = selection;
        SceneManager.LoadScene(1);
    }
    
}
