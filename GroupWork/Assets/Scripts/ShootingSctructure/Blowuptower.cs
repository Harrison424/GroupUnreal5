using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowuptower : MonoBehaviour
{
    public GameObject Reactor;
    public GameObject DMG1;
    
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
            DMG1.SetActive(true);
            Reactor.SetActive(false);
            
            
        }
    }
}
