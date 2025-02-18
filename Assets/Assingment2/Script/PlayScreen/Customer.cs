using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public float speed;
    [Range(0, 1)] public float tWalkIn = 0;
    [Range(0, 1)] public float tWalkOut = 0;
    public AnimationCurve moveCurve;

    Vector2 startPos;
    Vector2 assignSeat;
    private CustomerSpawner spawner;

    public GameObject orderUI;

    public float waitTime;
    public Vector2 leaveScreen;
    public Sprite madReaction;
    public Image reactionImage;
    bool canLeave = false;
    bool canDestroy = false;

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
        Leave();
    }

    public void AssignSeat(Vector2 seat)
    {
        assignSeat = seat;
    }

    void CustomerMove()
    {
        //incriment the time, when it reach 1 stay at 1, so it stop moving   
        tWalkIn += Time.deltaTime * speed;
        if (tWalkIn > 1)
        {
            tWalkIn = 1;
        }
       
        //use vector2 lerp to do the movement
        transform.position = Vector2.Lerp(startPos, assignSeat, moveCurve.Evaluate(tWalkIn));
    }

    void Order()
    {
        if(tWalkIn == 1)
        {
            orderUI.SetActive(true);
        }
    }

    void Leave()
    {
        if(tWalkIn == 1)
        {
            waitTime += Time.deltaTime;

            if(waitTime > 6)
            {
                reactionImage.sprite = madReaction;
                canLeave = true;
            }
        }

        if (canLeave)
        {
            tWalkOut += Time.deltaTime * speed;
            if (tWalkOut > 1)
            {
                tWalkOut = 1;
                canDestroy = true;
            }
            Vector2 currentPos = transform.position;
            transform.position = Vector2.Lerp(currentPos,leaveScreen, moveCurve.Evaluate(tWalkOut));
        }

        if (canDestroy)
        {   
            Destroy(gameObject);           
        }
    }   
}
