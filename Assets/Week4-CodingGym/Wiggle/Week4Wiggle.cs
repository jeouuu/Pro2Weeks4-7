using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Week4Wiggle : MonoBehaviour
{
    public Image image;

    private void Update()
    {
        IsMouseOver();

    }

    bool IsMouseOver()
    {
        Vector2 mousePos = Input.mousePosition;
       // RectTransform rt = image.rectTransform;

        //found this function online, I think it is pretty handy and works the same as spriteRenderere.bound.contain();
        if(RectTransformUtility.RectangleContainsScreenPoint(image.rectTransform, mousePos))
        {
            Debug.Log("touch");
            return true;
        } else
        {
            Debug.Log("f");
            return false;
        }
    }
}
