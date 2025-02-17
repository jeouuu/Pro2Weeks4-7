using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public float speed;
    [Range(0, 1)] public float t = 0;
    public AnimationCurve moveCurve;

    Vector2 startPos;
    Vector2 assignSeat;
    private CustomerSpawner spawner;

    public GameObject orderUI;


    private void Start()
    {        
        speed = Random.Range(0.1f, 0.5f);
        startPos = transform.position;
        orderUI.SetActive(false);
    }

    private void Update()
    {
        CustomerMove();
        Order();
    }

    public void AssignSeat(Vector2 seat)
    {
        assignSeat = seat;
    }

    void CustomerMove()
    {
        //incriment the time, when it reach 1 stay at 1, so it stop moving   
        t += Time.deltaTime * speed;
        if (t > 1)
        {
            t = 1;

        }
       
        //use vector2 lerp to do the movement
        transform.position = Vector2.Lerp(startPos, assignSeat, moveCurve.Evaluate(t));
    }

    void Order()
    {
        if(t == 1)
        {
            orderUI.SetActive(true);
        }
    }
   
}
