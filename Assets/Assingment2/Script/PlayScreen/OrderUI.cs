using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{
    //this script is for the order ui

    public GameObject orderUI;
    public GameObject orderTakenUI;
    public Button orderButton;

    public Sprite[] foodSprites;
    public Image foodImage;

    private void Start()
    {
        //make sure the order taken ui off at the beggninng 
        orderTakenUI.SetActive(false);       
    }

    public void PickFood()
    {
        //on button click,pick a random food from the food sprites and assign it to the food image on screen
        foodImage.sprite = foodSprites[Random.Range(0,foodSprites.Length)];
    }
        
    public void ShowUI()
    {
        //on button click show the order taken ui and turn off the order ui
        orderTakenUI.SetActive(true);
        orderUI.SetActive(false);        
    }


}
