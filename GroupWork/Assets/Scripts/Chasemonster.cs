using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    Animator Anmi;

    void Start()
    {
        Anmi = this.transform.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        
    }
    
}
