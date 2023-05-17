using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPlyers : MonoBehaviour
{
    public GameObject Plyersactiv;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Plyersactiv.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Plyersactiv.SetActive(false);
    }
}
