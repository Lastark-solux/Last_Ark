using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changeimg : MonoBehaviour
{
    public GameObject img1, img2, img3, img4, img5, img6, img7, img8, img9;

    public void Start()
    {
        img1.SetActive(true);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);
        img8.SetActive(false);
        img9.SetActive(false);
    }
    public void Update()
    {
        if ((UI.현침식도 >= 0) && (UI.현침식도 <= 20))
        {
            img1.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((UI.현침식도 >= 21) && (UI.현침식도 <= 30))
        {
            img2.SetActive(true);
            img1.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((UI.현침식도 >= 31) && (UI.현침식도 <= 40))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(true);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((41 <= UI.현침식도) && (UI.현침식도<= 50))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(true);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.현침식도 >= 51) && (UI.현침식도 <= 60))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(true);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.현침식도 >= 61) && (UI.현침식도 <= 70))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(true);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.현침식도 >= 71) && (UI.현침식도 <= 80))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(true);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.현침식도 >= 81) && (UI.현침식도 <= 90))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(true);
            img9.SetActive(false);
        }
        else if ((UI.현침식도 >= 91) && (UI.현침식도 <= 100))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(true);
        }
    }
}
