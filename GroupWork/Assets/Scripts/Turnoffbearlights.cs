using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnoffbearlights : MonoBehaviour
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
            light1.SetActive(false);
            light2.SetActive(false);

            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            light6.SetActive(false);
        }
    }
}
