using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        Vector2 pos = transform.position;
        PlayerMove();
    }

    void PlayerMove()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

      
    }

    void StayInScreen(Vector2 pos)
    {
        //check boundary
        Vector2 posInScreen = Camera.main.WorldToScreenPoint(pos);

        if(posInScreen.x > Screen.width)
        {
            Vector2 fixedPos = new Vector2(Screen.width, 0);
            
        }

    }


}
