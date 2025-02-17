using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public float speed;
    [Range(0, 1)] public float t = 0;
    public AnimationCurve moveCurve;

    Vector2 startPos;
    public Vector2[] seats = new Vector2[4];
    Vector2 pickSeat;

    public GameObject orderUI;

    private void Start()
    {
        pickSeat = seats[Random.Range(0, seats.Length)];
        speed = Random.Range(0.1f, 0.5f);
        startPos = transform.position;

        orderUI.SetActive(false);
    }

    private void Update()
    {
        CustomerMove();
        Order();
    }

    void CustomerMove()
    {
        //incriment the time, when it reach 1(which is the left edge) set it back to 0 (right edge).     
        t += Time.deltaTime * speed;
        if (t > 1)
        {
            t = 1;

        }

        //use vector2 lerp to do the movement
        transform.position = Vector2.Lerp(startPos, pickSeat, moveCurve.Evaluate(t));
    }

    void Order()
    {
        if(t == 1)
        {
            orderUI.SetActive(true);
        }
    }

}
