using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;
    private Rigidbody bulletRigidbody;

    

    public static int damage = 25;
    public int Damage;

    public int DestroyMe;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

    }


    private void Start()
    {
        float speed = 25f;
        bulletRigidbody.velocity = transform.forward * speed;


    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag=="Door" || other.tag == "Player")
        {

        }
        else { DestroyObject(this.gameObject); Instantiate(vfxHitRed, transform.position, Quaternion.identity); }
        

    }
    


}




