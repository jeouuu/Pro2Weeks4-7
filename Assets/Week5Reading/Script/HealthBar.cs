using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class HealthBar : MonoBehaviour
{
    public float health = 10f;
    public Slider visual;

    void Start()
    {
        visual.maxValue = 10;
        visual.minValue = 0;
        visual.value = health;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        visual.value = health;
    }

}
