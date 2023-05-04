using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceActiv : MonoBehaviour
{
    public GameObject CutActiv;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        CutActiv.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        CutActiv.SetActive(false);
    }
}
