using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSixPlayerMovement : MonoBehaviour
{
    //move the player

    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

    }

}
