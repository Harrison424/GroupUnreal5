using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DmgStructure : MonoBehaviour
{
    public GameObject structure1;
    public GameObject structure2;
    public GameObject DMG1;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            DMG1.SetActive(true);
            structure1.SetActive(false);
            structure2.SetActive(true);
        }
    }
}
