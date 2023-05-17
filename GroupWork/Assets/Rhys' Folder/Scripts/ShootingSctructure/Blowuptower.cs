using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowuptower : MonoBehaviour
{
    public GameObject Reactor;
    public GameObject Shield;
  
    
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
            Shield.SetActive(false);
         
            Reactor.SetActive(false);
            
            
        }
    }
}
