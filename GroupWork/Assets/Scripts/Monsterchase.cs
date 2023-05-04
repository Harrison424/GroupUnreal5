using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monsterchase : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    Animator Anmi;
    public int chase = 1;
    void Start()
    {
        Anmi = this.transform.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        Anmi.SetBool("Idle", true);
    }

    
    void Update()
    {
        if (chase == 1)
        {
            Anmi.SetBool("Idle", false);
            agent.SetDestination(target.position);
            Anmi.SetBool("Run", true);
        }
        

    }
    
}
