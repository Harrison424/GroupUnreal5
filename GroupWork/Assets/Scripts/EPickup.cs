using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPickup : MonoBehaviour
{
    public GameObject Plyers1;
    public GameObject Plyers2;
    public GameObject Fenceactivate;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            Plyers1.SetActive(false);
            Plyers2.SetActive(true);
            Fenceactivate.SetActive(true);
        }
    }
}
