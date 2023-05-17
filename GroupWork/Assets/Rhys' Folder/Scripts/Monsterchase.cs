using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monsterchase : MonoBehaviour
{
    public AudioSource EnemyHit;
    public int Killed;
    public Transform target;
    public Transform target2;
    NavMeshAgent agent;
    Animator Anmi;
    public int chase;
    public int Attack;
    public int Check;
    public int StillIn;
    public GameObject Test1;
    public float Counter;
    void Start()
    {
        Anmi = this.transform.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        Anmi.SetBool("Idle", true);
        Counter = 4;
        Killed = 5;
    }

    
    void Update()
    {
        if (chase == 1)
        {
            Anmi.SetBool("Idle", false);
            agent.SetDestination(target.position);
            Anmi.SetBool("Run", true);
        }
        if (Counter > 0)
        {
            Counter -= Time.deltaTime;
            chase = 0;
        }
        if (Counter < 0)
        {
            chase = 1;
            Anmi.SetBool("Attack", false);
        }
        if (StillIn == 1 && Counter < 0)
        {
            Test1.SetActive(true);
        }
        if(chase==0 && Attack ==1)
        {
            Anmi.SetBool("Run", false);
            Anmi.SetBool("Attack", true);
            agent.SetDestination(target2.position);
        }
        if(Killed == 0)
        {
            Test1.SetActive(true);
            Anmi.SetBool("Dead", true);
            agent.SetDestination(target2.position);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Killed--;
            //EnemyHit.Play();
        }
        else
        {
            Counter = 2;
            Attack = 1;
            Check = 0;
            StillIn = 1;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StillIn = 0;
        }

    }
}
