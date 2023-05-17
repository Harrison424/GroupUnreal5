using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrigChase : MonoBehaviour
{
    [SerializeField] GameObject Monster;
     Monsterchase monsterchase;

    void Start()
    {
        monsterchase = Monster.GetComponent<Monsterchase>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Timer"))
        {
            monsterchase.chase = 1;
        }
    }
}
