using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 시간석 : MonoBehaviour
{
    public GameObject 시간석1;
    public GameObject 시간석2;
    public GameObject 시간석3;
    public GameObject 깬시간석1;
    public GameObject 깬시간석2;
    public GameObject 깬시간석3;

    void Start()
    {
        시간석1.SetActive(false);
        시간석2.SetActive(false);
        시간석3.SetActive(false);

        깬시간석1.SetActive(false);
        깬시간석2.SetActive(false);
        깬시간석3.SetActive(false);
    }
    void Update()
    {
       
         if (Clipboard.시간석1==true)
        {
           시간석1.SetActive(true);
        }
        else
        {
            시간석1.SetActive(false);
        }

        if (Clipboard.시간석2 == true)
        {
            시간석2.SetActive(true);
        }
        else
        {
            시간석2.SetActive(false);
        }

       
        if (Clipboard.시간석3 == true) 
        {
            시간석3.SetActive(true);
        }
        else
        {
            시간석3.SetActive(false);
        }

        if (Clipboard.깬시간석1 == true)
        {
            깬시간석1.SetActive(true);
        }
        else
        {
            깬시간석1.SetActive(false);
        }
        if (Clipboard.깬시간석2 == true)
        {
            깬시간석2.SetActive(true);
        }
        else
        {
            깬시간석2.SetActive(false);
        }
        if (Clipboard.깬시간석3 == true)
        {
            깬시간석3.SetActive(true);
        }
        else
        {
            깬시간석3.SetActive(false);
        }
    }
    
       
}
