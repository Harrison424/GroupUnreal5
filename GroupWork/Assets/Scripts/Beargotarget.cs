using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements.Experimental;

public class Beargotarget : MonoBehaviour
{
   
    public Transform target;
    public Transform target2;
    public Transform myTransform;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block1"))
        {
            transform.LookAt(target2);
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
    }
}
