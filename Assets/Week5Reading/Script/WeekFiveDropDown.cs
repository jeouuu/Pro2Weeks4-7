using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeekFiveDropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Sprite newItemSprite;

    private void Start()
    {
        sr.sprite = dropdown.options[0].image;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TMP_Dropdown.OptionData item = new TMP_Dropdown.OptionData("new item", newItemSprite);
            dropdown.options.Add(item);
        }

        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            if (dropdown.options.Count > 0)
            {
                dropdown.options.RemoveAt(dropdown.options.Count - 1);
            }
            
        }
    }

    public void ValueChange(int index)
    {
        sr.sprite = dropdown.options[index].image;
    }
    
}
