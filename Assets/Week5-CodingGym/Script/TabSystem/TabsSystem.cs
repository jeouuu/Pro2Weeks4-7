using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabsSystem : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    private void Start()
    {
        image1.SetActive(false); 
        image2.SetActive(false);
        image3.SetActive(false);
    }

    public void TabOnePressed()
    {
        image1.SetActive(true);
        image2.SetActive(false);
        image3.SetActive(false);
    }

    public void TabTwoPressed()
    {
        image1.SetActive(false);
        image2.SetActive(true);
        image3.SetActive(false);
    }

    public void TabThreePressed()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(true);
    }
}
