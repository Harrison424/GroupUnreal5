using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittarget : MonoBehaviour
{
    public GameObject bridge1;
    public GameObject portal1;

    public float Wait = 8;
    public int Shoot = 0;
    public bool count;


   
    void Start()
    {
        
    }

    
    void Update()
    {
       if (count == true)
        {
            if (Wait >= 0)
            {
                Wait -= Time.deltaTime;
            }
            if (Wait <= 0)
            {
                Shoot = 1;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            bridge1.SetActive(true);
            portal1.SetActive(true);
            count = true;
        }


        

    }
}
