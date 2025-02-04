using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{

    Slider slider;
    
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void RandomRot()
    {
        slider.value = Random.Range(0, 360);
    }

}
