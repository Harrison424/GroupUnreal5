using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer4 : MonoBehaviour
{
    public GameObject bosscam1;
    public GameObject Player1;
    public GameObject bosscam;
    public GameObject triggerr;
    public GameObject timer3;
   

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
            bosscam1.SetActive(false);
            Player1.SetActive(true);
            bosscam.SetActive(false);
            triggerr.SetActive(false);
            timer3.SetActive(false);
            
            
            
        }
    }
}
