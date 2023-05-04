using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    Animator Anmi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Anmi.SetBool("Run", false);
            Anmi.SetBool("Attack", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Anmi.SetBool("Run", true);
        }
    }
}
