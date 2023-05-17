using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Noshielldd : MonoBehaviour
{
    public GameObject bossshield;
    
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
            bossshield.SetActive(false);

            


        }
    }
}
