using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6TargetScript : MonoBehaviour
{

    public float speed = 5f;

    public SpriteRenderer sr;
    public Color col;

    public AnimationCurve curve;
    float t;
    bool isDead = false;

    public WeekSixTargetSpawner spawner;

    private void Start()
    {
        speed = Random.Range(2f, 6f);
    }

    private void Update()
    {
        Vector2 pos  = transform.position;  
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        pos.x += speed * Time.deltaTime;

        //check edge
        if(screenPos.x < 0)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
            speed *= -1;
        } 
        if(screenPos.x > Screen.width)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
            speed *= -1;
        }

        transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                sr.color = col;
                isDead = true;
                Destroy(gameObject, 1);
                spawner.TargetHit(gameObject);
            }
        }

        if (isDead)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * curve.Evaluate(t);

        }
    }

}
