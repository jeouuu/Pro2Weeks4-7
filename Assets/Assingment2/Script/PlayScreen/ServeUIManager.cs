using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServeUIManager : MonoBehaviour
{
    //this script is for the serve food ui 

    public Sprite[] foodSprites;
    public Image foodImage;
    public Slider slider;
    public Button cookButton;

    public GameObject serveFoodUI;



    public void SliderChooseFood()
    {
        //on slider valuse change, choose a food sprite
        //set that food sprite to the food image shown on screen
        foodImage.sprite = foodSprites[(int)slider.value];
    }

    public void CookButton()
    {
        //on button click, turn off the serve food ui, return to the play screen
        serveFoodUI.SetActive(false);
    }

}
