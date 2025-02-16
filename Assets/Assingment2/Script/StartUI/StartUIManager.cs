using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartUIManager : MonoBehaviour
{
    //This script is for managing the start menu UI, manage the dropdown function and button function.//

    public TMP_Dropdown chefOption;
    public Image chefImage;
    public GameObject startUIScreen;

    private void Start()
    {
        startUIScreen.SetActive(true);
        chefImage.sprite = chefOption.options[0].image;
    }

    public void ChooseChef(int index)
    {
        chefImage.sprite = chefOption.options[index].image;
    }

    public void ButtonPlay()
    {
        startUIScreen.SetActive(false);
    }
}
