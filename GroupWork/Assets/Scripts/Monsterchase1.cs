using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monsterchase1 : MonoBehaviour
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
        agent.SetDestination(target.position);
    }
}
