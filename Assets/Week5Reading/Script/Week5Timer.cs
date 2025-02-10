using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Week5Timer : MonoBehaviour
{
    Slider slider;
    public float t;

    void Start()
    {
        slider = GetComponent<Slider>(); 
    }


    void Update()
    {
        t += Time.deltaTime;
        //% slider.maxValue, when the value gets to the slider  max, it return 0.
        slider.value = t % slider.maxValue;
    }
}
