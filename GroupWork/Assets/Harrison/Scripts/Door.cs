using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator Anim;
    //public AudioSource Sound;

    private void Start()
    {
        Anim = this.transform.parent.GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Anim.SetBool("character_nearby", true);
            //Sound.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Anim.SetBool("character_nearby", false);
            
        }
    }




}

