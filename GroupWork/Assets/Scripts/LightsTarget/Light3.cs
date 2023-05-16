using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light3 : MonoBehaviour
{
    public GameObject Gl4;
    public GameObject RL5;
    public GameObject GL5;
    public GameObject RL6;
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

            Gl4.SetActive(false);
            RL5.SetActive(true);
            GL5.SetActive(true);
            RL6.SetActive(false);

        }
    }
}
