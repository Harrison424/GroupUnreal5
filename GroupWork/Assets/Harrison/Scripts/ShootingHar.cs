using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingHar : MonoBehaviour
{
    public bool Shot;
    public float Wait;

    public Transform BulletProjectile;
    public Transform SpawnBulletPosition;

    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Wait >= 0)
        {
            Wait -= Time.deltaTime;
        }
        if (Wait <= 0)
        {
            Shot = false;
        }
        if (Input.GetMouseButtonDown(0) && Shot == false)
        {
            
           
                Instantiate(BulletProjectile, SpawnBulletPosition.position, SpawnBulletPosition.rotation);
            
            
            //shootSound.Play();
            Wait = 1;
            Shot = true;
        }
    }
  
}
