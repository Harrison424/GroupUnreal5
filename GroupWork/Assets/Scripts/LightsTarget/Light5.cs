using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light5 : MonoBehaviour
{
    public GameObject Gl6;
    public GameObject RL7;
    public GameObject GL7;
    public GameObject RL8;
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

            Gl6.SetActive(false);
            RL7.SetActive(true);
            GL7.SetActive(true);
            RL8.SetActive(false);

        }
    }
}
