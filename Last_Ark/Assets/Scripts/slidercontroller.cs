using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class slidercontroller : MonoBehaviour
{
    [SerializeField]
    private Slider 희망;
    [SerializeField]
    private Slider 식량;
    [SerializeField]
    private Slider 인구;
    [SerializeField]
    private Slider 침식도;

    private float slider_희망 = UI.현희망;
    private float slider_식량 = UI.현식량;
    private float slider_인구 = UI.현인구;
    private float slider_침식도 = UI.현침식도;

    public void buttononlcick()
    {
        UI.Handlegage(1, -20);
        
    }


    // Start is called before the first frame update
    void Start()
    {

       
        희망.value = (float)slider_희망 /100;
        식량.value = (float)slider_식량 /1000;
        인구.value = (float)slider_인구 /100000;
        침식도.value = (float)slider_침식도 /100;
    }

    // Update is called once per frame
    void Update()
    {
        slider_희망 = UI.현희망;
        slider_식량 = UI.현식량;
        slider_인구 = UI.현인구;
        slider_침식도 = UI.현침식도;


        희망.value = (float)slider_희망 / 100;
        식량.value = (float)slider_식량 / 1000;
        인구.value = (float)slider_인구 / 100000;
        침식도.value = (float)slider_침식도 / 100;

    }
}
