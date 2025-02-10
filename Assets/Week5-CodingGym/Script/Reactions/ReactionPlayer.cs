using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionPlayer : MonoBehaviour
{
    public float speed = 5f;
    public float offset;
    bool canChosseReaction = false;

    public Transform npc;
    public GameObject canvas;
    public Sprite[] reactions;
    public Image reactionSprite;

    private void Start()
    {
        canvas.SetActive(false);
    }


    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 npcPos = npc.position;

        //move the player and stay in screen
        PlayerMove();
        StayInScreen(pos);

        if (reachNPC(pos, npcPos))
        {
            if (canChosseReaction == false)
            {
                canChosseReaction = true;
                chooseReaction();
            }
            canvas.SetActive(true);
        } else
        {
            canChosseReaction = false;
            canvas.SetActive(false);
        }

        Debug.Log(canChosseReaction);

    }

    void PlayerMove()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);


    }

    void StayInScreen(Vector2 pos)
    {
        //check boundary
        Vector2 posInScreen = Camera.main.WorldToScreenPoint(pos);

        if (posInScreen.x > Screen.width)
        {
            Vector2 fixedPos = new Vector2(Screen.width, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = pos;
        }
        if (posInScreen.x < 0)
        {
            Vector2 fixedPos = new Vector2(0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = pos;
        }
        if (posInScreen.y < 0)
        {
            Vector2 fixedPos = new Vector2(0, 0);
            pos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            transform.position = pos;
        }
        if (posInScreen.y > Screen.height)
        {
            Vector2 fixedPos = new Vector2(0, Screen.height);
            pos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            transform.position = pos;
        }


    }

    bool reachNPC(Vector2 pos, Vector2 npcPoss)
    {
        if (pos.x < npcPoss.x + offset && pos.x > npcPoss.x - offset && pos.y > npcPoss.y - offset && pos.y < npcPoss.y + offset)
        {
            return true;
        } else
        {
            return false;
        }
    }

    void chooseReaction()
    {
        reactionSprite.sprite = reactions[Random.Range(0, reactions.Length)];
    }

}
