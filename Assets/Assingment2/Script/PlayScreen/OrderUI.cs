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

    bool orderTaken = false;

    private void Start()
    {
        orderTakenUI.SetActive(false);
       
    }

    public void ShowUI()
    {
        orderTakenUI.SetActive(true);
        orderUI.SetActive(false);
        orderTaken = true;
    }


}
