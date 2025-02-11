using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSixBarrel : MonoBehaviour
{
    //berrel movement that point to mouse

    //bool canRotate = true;

    private void Update()
    {
        //get the mouse pos
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        //caluculate the direction by subtracting two vectors to get the vector pointing from a to b
        Vector2 pointDir = mousePos - transform.position;

        

        //restrict it to 90 degree so it is not rotating 180 (i'll try to figure this part out 
        Vector3 rot = transform.eulerAngles;
        //if(rot.z == 90)
        //{
        //    rot.z = 90;
        //    canRotate = false;
        //}
        //if(rot.z == -90)
        //{
        //    rot.z = -90;
        //    canRotate = false;
        //}
        //else
        //{
        //    canRotate = true;
        //}

        //if (canRotate)
        //{}
            transform.up = pointDir;
        
    }

}
