using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer3 : MonoBehaviour
{
    public GameObject hologram;
    public GameObject Timer2;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Timer"))
        {
            hologram.SetActive(true);
            Destroy(Timer2);
           

        }
    }

}
