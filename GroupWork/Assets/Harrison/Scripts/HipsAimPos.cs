using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipsAimPos : MonoBehaviour
{
    
    public Transform bone;
    public Transform target;
    public Transform aimTransform;

    public Transform BulletProjectile;
    public Transform SpawnBulletPosition;

    private float aimColliderLayerMask;

    public AudioSource shootSound;

    public bool Shot;
    public float Wait;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Wait >= 0)
        {
            Wait-=Time.deltaTime;
        }
        if(Wait <=0)
        {
            Shot = false;
        }
        Vector3 mouseWorldPosition = Vector3.zero;
        mouseWorldPosition = target.position;
        
           
            
                if (Input.GetMouseButtonDown(0))
                {
                    Vector3 aimDir = (mouseWorldPosition - SpawnBulletPosition.position).normalized;
                    Instantiate(BulletProjectile, SpawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
                    //shootSound.Play();
                    Wait = 1;
                    Shot = true;
                    //starterAssetsInputs.shoot = false;
                    //animator.SetLayerWeight(1, Mathf.Lerp(animator.GetLayerWeight(1), 0f, Time.deltaTime * 10f));
                }
            
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = target.position;
        AimAtTarget(bone, targetPosition);

    }


    private void AimAtTarget( Transform bone, Vector3 targetPosition)
    {
       Vector3 aimDirection = aimTransform.forward;
        Vector3 targetDirection = targetPosition - aimTransform.position;
        Quaternion aimTowards = Quaternion.FromToRotation(aimDirection,targetDirection);
        bone.rotation = aimTowards * bone.rotation;
    }
   


}
