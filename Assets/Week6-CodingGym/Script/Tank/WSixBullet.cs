using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSixBullet : MonoBehaviour
{
    public float speed = 5;
    public bool isFired = false;

    Vector3 pointDir;

    private void Start()
    {
        pointDir.z = 0;
    }

    private void Update()
    {
        if (isFired)
        {            
            Movement();
            //transform.parent = null;
        }
        else
        {
            PointMouse();
        }
        
    }

    void PointMouse()
    {
        //get the bullet point at mouse as well
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(transform.position);
        mousePos.z = 0;

        pointDir = mousePos - transform.position;

        transform.up = pointDir;
    }

    void Movement()
    {
        transform.position += pointDir * speed * Time.deltaTime;
        //transform.position = Vector3.one * speed * Time.deltaTime;
    }

    public void Fire()
    {
        isFired = true;
        transform.parent = null;    
    }

}
