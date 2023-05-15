using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoEBoss : MonoBehaviour
{
    public int Once;
    public float Wait;
    public AudioSource SoundBeep;
    public AudioSource SoundEnd;
    public Transform vfxEnd;

    // Start is called before the first frame update
    void Start()
    {
        Wait = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Wait != -1)
        {
            Wait -= Time.deltaTime;
        }
        if (Wait <= 0 && Once == 0)
        {
            Instantiate(SoundEnd, transform.position, Quaternion.identity);
            Instantiate(vfxEnd, transform.position, Quaternion.identity);
            Once = 1;
            
        }
        if (Wait <= -1)
        {
            DestroyObject(this.gameObject);
        }
    }
}
