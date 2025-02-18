using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    //this script is for the customer prefab


    public float speed;
    [Range(0, 1)] public float tWalkIn = 0;
    [Range(0, 1)] public float tWalkOut = 0;
    public AnimationCurve moveCurve;

    //need reference from the spawner script
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
        //pick a random speed
        speed = Random.Range(0.1f, 0.5f);
        startPos = transform.position;
        //and set the order ui off
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
        //assign the seat that is pick from the spawner
        assignSeat = seat;
    }

    void CustomerMove()
    {
        //incriment the time after spawn, when it reach 1 stay at 1, so it stop moving   
        //use vector2 lerp to do the movement, from start position to the asign seat
        tWalkIn += Time.deltaTime * speed;
        if (tWalkIn > 1)
        {
            tWalkIn = 1;
        }       
        transform.position = Vector2.Lerp(startPos, assignSeat, moveCurve.Evaluate(tWalkIn));
    }

    void Order()
    {
        //when tWalkIn == 1 they are at seat, order ui pops up
        if (tWalkIn == 1)
        {
            orderUI.SetActive(true);
        }
    }

    void Leave()
    {
        //when tWalkIn = 1, means they are at seat, start counting wait time. 
        //when wait time reach 6 seconds, a mad reaction pops up, and they will leave
        if(tWalkIn == 1)
        {
            waitTime += Time.deltaTime;

            if(waitTime > 6)
            {
                reactionImage.sprite = madReaction;
                canLeave = true;
            }
        }

        //when they leave, restore the currentposition, and set the end location out of the screen
        //use lerp again to do the movement
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

        //when tWalkOut > 1, means they are out of the screen, then destroy yourself.
        if (canDestroy)
        {   
            Destroy(gameObject);           
        }
    }   
}
