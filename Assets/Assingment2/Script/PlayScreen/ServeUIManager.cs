using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServeUIManager : MonoBehaviour
{
    public Sprite[] foodSprites;
    public Image foodImage;
    public Slider slider;
    public Button cookButton;

    public GameObject serveFoodUI;



    public void SliderChooseFood()
    {
        foodImage.sprite = foodSprites[(int)slider.value];
    }

    public void CookButton()
    {
        serveFoodUI.SetActive(false);
    }

}
