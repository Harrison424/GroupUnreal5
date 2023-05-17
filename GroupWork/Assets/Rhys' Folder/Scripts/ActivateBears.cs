using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBears : MonoBehaviour
{
    public GameObject Timer;
    public GameObject alarm;
    public GameObject Bear1;
    public GameObject Bear2;
    public GameObject Bear3;
    public GameObject Bear4;
    public GameObject Bear5;
    public GameObject Bear6;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Timer.SetActive(true);
        alarm.SetActive(true);
        Bear1.SetActive(true);
        Bear2.SetActive(true);
            
        Bear3.SetActive(true);
        Bear4.SetActive(true);
        Bear5.SetActive(true);
        Bear6.SetActive(true);
        

    }
}
