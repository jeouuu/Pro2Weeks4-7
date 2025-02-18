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
        //change the chefImage on screen depends on the one player choose from the dropdown
        chefImage.sprite = chefOption.options[index].image;
    }

    public void ButtonPlay()
    {
        //when the play button is pressed, disable the start ui screen --> enter the play screen
        startUIScreen.SetActive(false);
    }
}
