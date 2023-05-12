using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int Health;
    public int TakeDmg;
    // Start is called before the first frame update
    void Start()
    {
        Health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Attack")
        {
            if(TakeDmg == 1)
            {
                Health--;
            }
            
        }
    }
}
