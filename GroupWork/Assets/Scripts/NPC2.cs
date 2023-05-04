using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NPC2 : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public Transform target3;
    NavMeshAgent agent;
    Animator Anmi;
    public int NextPath;
    public int doOnce;

    // Start is called before the first frame update
    void Start()
    {
        Anmi = this.transform.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NextPath == 0)
        {
            agent.SetDestination(target.position);
        }
        if (NextPath == 1)
        {
            agent.SetDestination(target2.position);
        }
        if (NextPath == 2)
        {
            agent.SetDestination(target3.position);
        }
        if(NextPath == 3)
        {
            NextPath= 0;
        }
       if(this.transform.position == target.position)
        {
            NextPath=1;
        }
        if (this.transform.position == target2.position)
        {
            NextPath = 2;
            doOnce = 0;
        }
        if (this.transform.position == target3.position && doOnce == 0)
        {
            NextPath = 3;
            doOnce++;
        }
    }
   
}