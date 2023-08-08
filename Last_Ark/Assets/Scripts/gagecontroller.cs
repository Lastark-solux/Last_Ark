using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UI : MonoBehaviour
{
   
    public static float 현희망 = 50;
    public static float 현식량 = 500;
    public static float 현인구 = 30000;
    public static float 현침식도 = 40;
    



    public static void Handlegage(int which,float much) // gage의 max값 설정을 빼 먹었어서 추가함 !!
    {
        if ( which ==1)
           {
              현희망 += much;


            if (현희망>=100)
            {
                현희망 = 100;
            }
            
            else if (현희망<=0)
            {
                현희망 = 0;
            }

            
           }
        else if ( which== 2 ){
            현식량 += much;


            if (현식량 >= 1000)
            {
                현식량 = 1000;
            }

            else if (현식량 <= 0)
            {
                현식량 = 0;
            }



        }
        else if ( which == 3) {
            현인구 += much;


            if (현인구 >= 100000)
            {
                현인구 = 100000;
            }

            else if (현인구 <= 0)
            {
                현인구 = 0;
            }


        }
        else
        {
            현침식도 += much;

            if (현침식도 >= 100)
            {
                현침식도 = 100;
            }

            else if (현침식도 <= 0)
            {
                현침식도 = 0;
            }

        }



    }

    public static void gagemechanism() //스테이지가 넘어갈수록 기본 적용되는 게이지의 증감을 구현하는 함수 !  스테이지가 넘어갈 때 한 번 적용해주면 됨 !
    {
        식량메커니즘();
        침식도메커니즘();
        인구수메커니즘();
    }

    public static void 식량메커니즘() // 스테이지와 인구 수 조건에 따라서 식량을 감소시켜줌 . 아래 함수들도 다 동일한 메커니즘 
    {
        if (현인구 <= 10000)
        {
            현식량 -= 60;
        }
        else if ((10000 < 현인구) && (현인구 <= 30000))
        {
            현식량 -= 80;
        }
        else if ((30000 < 현인구) && (현인구 <= 50000))
        {
            현식량 -= 120;
        }
        else if ((50000 < 현인구) && (현인구 <= 70000))
        {
            현식량 -= 140;
        }
        else if ((70000 < 현인구) && (현인구 <= 90000))
        {
            현식량 -= 160;
        }
        else
        {
            현식량 -= 180;
        }


        if (Clipboard.stagenum<=6)
        {
            현식량 += 80;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            현식량 += 100;

        }
        else
        {
            현식량 += 120;
        }
        print(현식량);
        print(Clipboard.stagenum);
    }

    public static void 침식도메커니즘() 
    {
        if (Clipboard.stagenum <= 6)
        {
            현침식도 += 4;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            현침식도 += 5;

        }
        else
        {
            현침식도 += 6;
        }


        if (현인구 <= 10000)
        {
            현침식도 += 0;
        }
        else if ((10000 < 현인구)&& (현인구 <= 30000))
        {
            현침식도 -= 1;
        }
        else if ((30000 < 현인구) && (현인구 <= 50000))
        {
            현침식도 -=2;
        }
        else if ((50000 < 현인구) && (현인구 <= 70000))
        {
            현침식도  -=  3;
        }
        else if ((70000 < 현인구) && (현인구 <= 90000))
        {
            현침식도 -= 4;
        }
        else
        {
            현침식도 -= 5;
        }

    }

    private static void 인구수메커니즘()
    {
        if (Clipboard.stagenum <= 6)
        {
            현인구 += 1000;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            현인구 += 2000;

        }
        else
        {
            현인구 += 3000;
        }

    }

   


 
   
    
}
