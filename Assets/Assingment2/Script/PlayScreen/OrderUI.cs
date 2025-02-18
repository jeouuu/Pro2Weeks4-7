using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{

    public GameObject orderUI;
    public GameObject orderTakenUI;
    public Button orderButton;

    public Sprite[] foodSprites;
    public Image foodImage;

    

    private void Start()
    {
        orderTakenUI.SetActive(false);       
    }

    public void PickFood()
    {
        foodImage.sprite = foodSprites[Random.Range(0,foodSprites.Length)];
    }
        
    public void ShowUI()
    {
        orderTakenUI.SetActive(true);
        orderUI.SetActive(false);        
    }


}
