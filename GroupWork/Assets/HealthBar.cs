using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float Maxhealth;
    public float health;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        Maxhealth = 100;
        health = Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = Maxhealth;
        slider.value = health;
        if (Input.GetKeyDown(KeyCode.F))
        {
            health -= 20;
        }
    }
}
