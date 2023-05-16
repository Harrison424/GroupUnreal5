using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittarget : MonoBehaviour
{
    public GameObject bridge1;
    public GameObject portal1;

    


   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            bridge1.SetActive(true);
            portal1.SetActive(true);

            
        }
    }
}
