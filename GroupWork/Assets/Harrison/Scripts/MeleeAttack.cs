using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    Target target;
    [SerializeField] GameObject Cube;
    public GameObject MeleeHit;
    public float Counter;
    public int Attack;
    int DoDmg;
    int doOnce;
    public GameObject MeleeAnmi;
    // Start is called before the first frame update
    void Start()
    {
        target = Cube.GetComponent<Target>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool Fight = Input.GetKeyDown(KeyCode.F);
        if (Fight)
        {
            Attack1();
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            MeleeHit.SetActive(false);
        }
        if (Counter > 0) 
        {
            Counter -= Time.deltaTime;
        }
       if (Counter <=0)
        {
            Attack = 0;
            DoDmg = 0;
            doOnce = 0;
            target.TakeDmg = 0;
        }
       if(DoDmg == 1 && doOnce == 0)
        {
            MeleeAnmi.SetActive(true);
            doOnce = 1;
            target.TakeDmg = 1;
        }
    }
    private void Attack1 ()
    {
        if(Attack == 0) {
            MeleeHit.SetActive(true);
            Counter = 1;
            Attack = 1;
            DoDmg = 1;
        }
    }
   
}
