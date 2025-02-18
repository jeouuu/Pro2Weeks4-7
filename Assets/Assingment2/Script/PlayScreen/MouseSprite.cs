using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSprite : MonoBehaviour
{

    private void Update()
    {
        //keep the mouse sprite at mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }

}
