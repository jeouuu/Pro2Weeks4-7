using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    public float speed = 5f;
   // public bool canChime;
    float startA = 360f;
    float lastA;

    void Start()
    {

    }

    void Update()
    {
        Vector3 ang = transform.eulerAngles;
        Rotate(ang);
        Chime(ang);
        //float currentA = ang.z;
       for(int i = -30; i >= -360; i += -30)
        {
            if (ang.z - startA < i)
            {
                // startA = ang.z;
                Debug.Log("true");
            } else
            {
                //Debug.Log("false"); 
            }
        }
        
        Debug.Log(ang.z - startA);

    }

    void Rotate(Vector3 ang)
    {

        ang.z += speed * Time.deltaTime;
        transform.eulerAngles = ang;
    }

    void Chime(Vector3 ang)
    {
        
    }
}
