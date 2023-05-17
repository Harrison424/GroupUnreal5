using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatfire : MonoBehaviour
{
    public Transform target;
    public Transform eBulletSpawn;
    public Transform eBullet;
    public float timeBtwShots;
    void Start()
    {
        

    }

    
    void Update()
    {
        transform.LookAt(target);
        if (timeBtwShots <= 0)
        {
            Vector3 aimDir = (target.position - eBulletSpawn.position + new Vector3(0.0f, 1f, 0.0f)).normalized;
            Instantiate(eBullet, eBulletSpawn.position, Quaternion.LookRotation(aimDir, Vector3.up));
            timeBtwShots = 1;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

}
