using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBears : MonoBehaviour
{
    public GameObject Timer;
    public GameObject alarm;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Timer.SetActive(true);
        alarm.SetActive(true);
    }
}
