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

public class RealEnding : MonoBehaviour
{
    public TextMeshProUGUI 대사1;
    public GameObject 버튼;
    public static int count = 1;

    void Start()
    {
        대사1.text = "당신은 무사히 성을 운영했습니다! ";



    }
  


    public void 클릭()
    {
            

            if (count == 1)
                {
                    대사1.text = "이제 당신과 성주들에겐 밝은 미래만이 남았을 것입니다";



                }
            else if (count == 2)
                {


                    대사1.text = "...아마도.";

                }

            

            else if (count>=3)
            {

                
                버튼.SetActive(false);

            }
           
           

            count++;
     }
       
                
               
      


}



