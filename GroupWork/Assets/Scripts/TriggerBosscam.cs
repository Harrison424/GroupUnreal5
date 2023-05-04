using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBosscam : MonoBehaviour
{
    public GameObject bosscam;
    public GameObject Player1;
    public GameObject Timer1;
    public GameObject Timer2;
    public GameObject Timer3;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Player1.SetActive(false);
        bosscam.SetActive(true);
        Timer1.SetActive(true);
        Timer2.SetActive(true);
        Timer3.SetActive(true);

        
    }
}
