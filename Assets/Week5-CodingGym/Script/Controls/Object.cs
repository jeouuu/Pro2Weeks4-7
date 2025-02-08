using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    public Sprite[] sprites;
    public Slider slider;
    public SpriteRenderer sr;


    public void SpriteChange()
    {
        sr.sprite = sprites[Random.Range(0, sprites.Length)]
; }

    public void RotationChange()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z = slider.value;
        transform.eulerAngles = rot;
    }

}
