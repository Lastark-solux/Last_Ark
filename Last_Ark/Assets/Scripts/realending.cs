using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Globalization;
using System.Net.Mail;
using TMPro;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System;

using Random = UnityEngine.Random;
using System.Linq;

public class realending : MonoBehaviour
{
    public TextMeshProUGUI 대사1;
    public GameObject 버튼;
    public static int count = 1;

    void Start()
    {
        대사1.text = "당신은 과거의 비밀을 밝혀냈습니다. ";



    }



    public void 클릭()
    {


        if (count == 1)
        {
            대사1.text = "당신은 동료들과 시간석을 적절히 사용해 현재를 지켜냈습니다.";



        }
        else if (count == 2)
        {


            대사1.text = "이제, 당신은 신뢰하는 동료들, 당신에게 충성하는 주민들, 굳건한 성과 함께 이 멸망한 세계 안에서 운영해 나갈 것입니다.";

        }



        else if (count == 3)
        {

            대사1.text = "오래오래 행복하게";


        }

        else if (count >= 4)
        {
            버튼.SetActive(false);
        }

        count++;
    }


}
