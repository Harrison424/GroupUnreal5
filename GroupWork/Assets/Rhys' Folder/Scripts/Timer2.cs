using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer2 : MonoBehaviour
{
    public GameObject bosscam;
    public GameObject bosscam1;
    public GameObject Timer;

   
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
            bosscam.SetActive(false);
            bosscam1.SetActive(true);
            Destroy(Timer);

        }
    }
}
