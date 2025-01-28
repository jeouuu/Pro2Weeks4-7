using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ang= transform.eulerAngles;
        ang.z += speed * Time.deltaTime;
        transform.eulerAngles = ang;
    }
}
