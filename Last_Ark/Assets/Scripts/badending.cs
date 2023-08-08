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

public class endingimg : MonoBehaviour
{
    public GameObject 이미지1;
    public GameObject 이미지2;
    public GameObject 이미지3;
    public GameObject 이미지4;
    public GameObject 대사;
    public GameObject 버튼;
    public TextMeshProUGUI 대사1;
    public TextMeshProUGUI 대사2;
    public TextMeshProUGUI 대사3;
    public static int count=0;

    void Start()
    {
        이미지1.SetActive(true);
        이미지2.SetActive(false);
        이미지3.SetActive(false);
        이미지4.SetActive(false);
        대사.SetActive(false);
    }

    public void Onclick함수()
    {   
        if (count<=2)
        {
            if (count == 0)
            {
                대사.SetActive(true);
                if (Clipboard.침식도엔딩 == true)
                {
                    대사1.text = "당신의 성은 멸망했습니다.";
                }
                else if (Clipboard.식량엔딩 == true)
                {
                    대사1.text = "당신의 성은 멸망했습니다.";
                }
                else if (Clipboard.인구엔딩 == true)
                {
                    대사1.text = "당신의 성은 멸망했습니다";
                }
            }

            else if (count == 1)
            {
                이미지1.SetActive(false);
                이미지2.SetActive(true);
                이미지3.SetActive(false);
                이미지4.SetActive(false);
                if (Clipboard.침식도엔딩 == true)
                {
                    대사2.text = "완벽히 어두워진 당신의 성에 사람들은 절망에 빠졌습니다.";
                }
                else if (Clipboard.식량엔딩 == true)
                {
                    대사2.text = "성 내의 모든 사람들은 끔찍한 배고픔으로 인해 죽거나 떠났습니다";
                }
                else if (Clipboard.인구엔딩 == true)
                {
                    대사2.text = "각종 전쟁, 기근, 전염병으로 인해 사람들은 천천히 죽어갔고, 그 누구도 남지 않았습니다.";
                }
            }
            else if (count==2)
            {
                이미지1.SetActive(false);
                이미지2.SetActive(false);
                이미지3.SetActive(true);
                이미지4.SetActive(false);
                if (Clipboard.침식도엔딩 == true)
                {
                    대사3.text = "성난 주민들은 반란을 일으켰습니다. 사람들은 당신을 단두대에 올려 처형합니다.";
                }
                else if (Clipboard.식량엔딩 == true)
                {
                    대사3.text = "당신은 폐허가 된 성 안에서 혼자 남아 굶주림에 서서히 죽어갑니다.";
                }
                else if (Clipboard.인구엔딩 == true)
                {
                    대사3.text = "아무도 남지 않은 성에서 당신은 혼자 쓸쓸히 빛을 바라봅니다";
                }
            }
      
        }
        
        else
        {
            이미지1.SetActive(false);
            이미지2.SetActive(false);
            이미지3.SetActive(false);
            이미지4.SetActive(true);
            버튼.SetActive(false);

        }

        count++;

        
    }
    

}
