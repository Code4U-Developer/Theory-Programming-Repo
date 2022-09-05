using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int VehSelected;
    private bool simulatorRunning;

    // Start is called before the first frame update
    private void Awake()
    {
    if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }

    Instance = this;
    Instance.simulatorRunning = false;
    DontDestroyOnLoad(gameObject);
    }
    /*[System.Serializable]
    class SaveData
    {
    public int VehSelected;
    public float BestDistance;
    }*/
}
