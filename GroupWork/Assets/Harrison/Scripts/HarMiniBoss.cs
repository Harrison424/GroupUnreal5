using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarMiniBoss : MonoBehaviour
{
    public float Wait;
    public Transform Target;
    public Transform AOEAttack;
    public bool ON;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ON == true)
        {
                if (Wait >= 0)
                {
                    Wait -= Time.deltaTime;
                }
                if (Wait <= 0)
                {
                    AOE();
                }
        }
        
    }
    void AOE()
    {
            Instantiate(AOEAttack, Target.position, Target.rotation);
            Wait = 3;       
    }
}
