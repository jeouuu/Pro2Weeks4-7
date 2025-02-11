using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSixTankMovement : MonoBehaviour
{
    public float speed = 1f;
    

    private void Update()
    {     

        //move the tank
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        //check edge
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x > Screen.width)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
            transform.position = pos;
        }
        if (screenPos.x < 0)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
            transform.position = pos;
        }

    }

}
