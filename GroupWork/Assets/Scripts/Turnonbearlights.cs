using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonbearlights : MonoBehaviour
{
    public GameObject light1;   
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    
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
            light1.SetActive(true);
            light2.SetActive(true);
                
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
                light6.SetActive(true);
        }
    }
}
