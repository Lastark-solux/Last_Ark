using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UI : MonoBehaviour
{
   
    public static float ����� = 0;
    public static float ���ķ� = 350;
    public static float ���α� = 3000;
    public static float ��ħ�ĵ� = 3;
    



    public static void Handlegage(int which,float much) // gage�� max�� ������ �� �Ծ�� �߰��� !!
    {
        if ( which ==1)
           {
              ����� += much;


            if (�����>=100)
            {
                ����� = 100;
            }
            
            else if (�����<=0)
            {
                ����� = 0;
            }

            
           }
        else if ( which== 2 ){
            ���ķ� += much;


            if (���ķ� >= 1000)
            {
                ���ķ� = 1000;
            }

            else if (���ķ� <= 0)
            {
                ���ķ� = 0;
            }



        }
        else if ( which == 3) {
            ���α� += much;


            if (���α� >= 100000)
            {
                ���α� = 100000;
            }

            else if (���α� <= 0)
            {
                ���α� = 0;
            }


        }
        else
        {
            ��ħ�ĵ� += much;

            if (��ħ�ĵ� >= 100)
            {
                ��ħ�ĵ� = 100;
            }

            else if (��ħ�ĵ� <= 0)
            {
                ��ħ�ĵ� = 0;
            }

        }



    }

    public static void gagemechanism() //���������� �Ѿ���� �⺻ ����Ǵ� �������� ������ �����ϴ� �Լ� !  ���������� �Ѿ �� �� �� �������ָ� �� !
    {
        �ķ���Ŀ����();
        ħ�ĵ���Ŀ����();
        �α�����Ŀ����();
    }

    public static void �ķ���Ŀ����() // ���������� �α� �� ���ǿ� ���� �ķ��� ���ҽ����� . �Ʒ� �Լ��鵵 �� ������ ��Ŀ���� 
    {
        if (���α� <= 10000)
        {
            ���ķ� -= 50;
        }
        else if ((10000 < ���α�) && (���α� <= 30000))
        {
            ���ķ� -= 80;
        }
        else if ((30000 < ���α�) && (���α� <= 50000))
        {
            ���ķ� -= 110;
        }
        else if ((50000 < ���α�) && (���α� <= 70000))
        {
            ���ķ� -= 130;
        }
        else if ((70000 < ���α�) && (���α� <= 90000))
        {
            ���ķ� -= 150;
        }
        else
        {
            ���ķ� -= 170;
        }


        if (Clipboard.stagenum<=6)
        {
            ���ķ� += 400;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            ���ķ� += 350;

        }
        else
        {
            ���ķ� += 300;
        }
        print(���ķ�);
        print(Clipboard.stagenum);
    }

    public static void ħ�ĵ���Ŀ����() 
    {
        if (Clipboard.stagenum <= 6)
        {
            ��ħ�ĵ� += 3;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            ��ħ�ĵ� += 5;

        }
        else
        {
            ��ħ�ĵ� += 7;
        }


        if (���α� <= 10000)
        {
            ��ħ�ĵ� += 0;
        }
        else if ((10000 < ���α�)&& (���α� <= 30000))
        {
            ��ħ�ĵ� -= 2;
        }
        else if ((30000 < ���α�) && (���α� <= 50000))
        {
            ��ħ�ĵ� -=3;
        }
        else if ((50000 < ���α�) && (���α� <= 70000))
        {
            ��ħ�ĵ�  -=  4;
        }
        else if ((70000 < ���α�) && (���α� <= 90000))
        {
            ��ħ�ĵ� -= 5;
        }
        else
        {
            ��ħ�ĵ� -= 6;
        }

    }

    private static void �α�����Ŀ����()
    {
        if (Clipboard.stagenum <= 6)
        {
            ���α� += 2000;
        }
        else if ((7 <= Clipboard.stagenum) && (Clipboard.stagenum <= 12))
        {
            ���α� += 4000;

        }
        else
        {
            ���α� += 5000;
        }

    }

   


 
   
    
}
