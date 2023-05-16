using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    public GameObject Gl2;
    public GameObject RL3;
    public GameObject GL3;
    public GameObject RL4;
    


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

            Gl2.SetActive(false);
            RL3.SetActive(true);
            GL3.SetActive(true);
            RL4.SetActive(false);

        }
    }
}
