using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Noshielldd : MonoBehaviour
{
    public GameObject bossshield;
    public GameObject Generator;
    
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
            Generator.SetActive(false);
            Destroy(bossshield);

            


        }
    }
}
