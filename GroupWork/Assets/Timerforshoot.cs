using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerforshoot : MonoBehaviour
{
    public int shoot = 1;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Timer"))
        {
            shoot = 1;
            // shoot player
        }
    }
}
