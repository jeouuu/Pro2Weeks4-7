using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChefMovement : MonoBehaviour
{
    //This script is for chef movement 

    public float speed = 5f;

    //getting the public references of the counters
    public SpriteRenderer wall1;
    public SpriteRenderer wall2;
    public SpriteRenderer wall3;
    public SpriteRenderer wall4;
    public float wallOffset = 0.5f;

    //need a reference to this gameObject sprite and chefImage sprite in start ui canvas
    SpriteRenderer chefSprite;
    public Image chefImage;

    private void Start()
    {
        //get this gameObject spriteRenderer by GetComponent
        chefSprite = GetComponent<SpriteRenderer>();      
    }

    private void Update()
    {
        //set the this chefSprite to the one player choose from the StartUI Canvas
        chefSprite.sprite = chefImage.sprite;
        Vector2 chefPos = transform.position;
        ChefMove();
        Boundry(chefPos);
    }

    void ChefMove()
    {
        //this function is for chef movement with keyboard input wasd
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }

    void Boundry(Vector2 chefPos)
    {
        //this function is for checking if chef is overlaping/crossing the counter walls, if so set their position at the edge of the wall to prevent overlap.
        //bound.contain can check if chefPos is in the bound box, and the bound.min/max is the edge of that bound box counting from the center. 
        if (wall1.bounds.Contains(chefPos))
        {
            chefPos.x = wall1.bounds.max.x + wallOffset;
            transform.position = chefPos;
        } 
        if (wall2.bounds.Contains(chefPos))
        {
            chefPos.x = wall2.bounds.min.x - wallOffset;
            transform.position = chefPos;
        } 
        if (wall3.bounds.Contains(chefPos))
        {
            chefPos.y = wall3.bounds.max.y + wallOffset;
            transform.position = chefPos;
        }
        if (wall4.bounds.Contains(chefPos))
        {
            chefPos.y = wall4.bounds.min.y - wallOffset;
            transform.position = chefPos;
        }        
    }
}
