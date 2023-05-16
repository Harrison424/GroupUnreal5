using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light1 : MonoBehaviour
{
    public GameObject GL1;
    public GameObject RL1;

    public GameObject RL2;
    public GameObject GL2;
   
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
            RL1.SetActive(true);
            GL1.SetActive(false);
            GL2.SetActive(true);
            RL2.SetActive(false);

            
        }
    }
}
