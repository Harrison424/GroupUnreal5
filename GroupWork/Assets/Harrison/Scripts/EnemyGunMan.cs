using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunMan : MonoBehaviour
{
    public Transform target;
    public float timeBtwShots;
    public Transform eBullet;
    public Transform eBulletSpawn;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FaceTarget();
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
    void FaceTarget()
    {
        
        Vector3 direction = (target.position - transform.position).normalized;
        Anim.SetBool("Aim", true);
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

}
