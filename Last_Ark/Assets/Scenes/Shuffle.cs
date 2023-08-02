using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

public class Shuffle : MonoBehaviour
{
    int count;
    string[] common = { "1-1", "1-2", "1-3", "1-4","1-5","1-6","1-7","1-8", "2-1", "2-2", "2-3", "2-4", "3-1", "3-2", "3-3", "3-4" };
    string[] special = { "a+b", "a, 6달 차", "b+c", "a+c, 3달 차" };
    string[] ssm = new string[8];
    bool a_flag = false;
    bool b_flag = false;
    bool c_flag = false;
    bool second_level = false;
    bool third_level = false;
    int yy = 2023;
    int mm = 1;
    int m_count = 1;

    //TMP_Text gameDate;
    GameObject gameDate, gameSsm;

    // 버튼을 눌렀을 때 호출될 함수
    void Start()
    {
        this.gameDate = GameObject.Find("Date");
        count = 0;
        Array.Fill(ssm, "none");
    }

    public void ClickBtn()
    {
        print("버튼 클릭");

        // 방금 클릭한 게임 오브젝트를 가져와서 저장
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
        flag_ctr(clickObject.name);

        print(clickObject.name + " , " + a_flag + b_flag + c_flag +" "+yy+" "+mm);
        print(ssm);
    }

    void flag_ctr(string name)
    {
        if (name == "a_trg")
        {
            if (!a_flag) a_flag = true;
            else a_flag = false;
        }
        else if (name == "b_trg")
        {
            if (!b_flag) b_flag = true;
            else b_flag = false;
        }
        else if (name == "c_trg")
        {
            if (!c_flag) c_flag = true;
            else c_flag = false;
        }
        else
        {
            count = 0;
            Array.Fill(ssm, "none");
            date_ctr();
            ssm_ctr(count);
        }
    }
    void date_ctr()
    {
    mm++;
        m_count++;
        if (mm > 12)
        {
            mm = 1;
            yy++;
        }

        if (mm >= 6) second_level = true;
        if (mm >= 12) third_level = true;

        if (mm >= 10)
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". " + mm + ". 01";
        }
        else
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". 0" + mm + ". 01";
        }
    }

    void ssm_ctr(int num)
    {
        int count = num;
        int maxNum = 7;
        int ranNum = -1;
        //flag로 리스트에 넣은 다음 disable로 가용성 라인을 체크하면 될 것 같음 
        if (a_flag)
        {
            if (b_flag)
            {
                ssm[count] = special[0];
                count++;
            }
            if(m_count == 6)
            {
                ssm[count] = special[1];
                count++;
            }
            if(c_flag && m_count == 3)
            {
                ssm[count] = special[3];
                count++;
            }
        }

        if (b_flag && c_flag)
        {
            ssm[count] = special[2];
            count++;
        }



        if (second_level) maxNum = maxNum + 4;
        if (third_level) maxNum = maxNum + 4;

        int cnt = 8 - count;
        int[] numArray = getRandomInt(cnt, 0, maxNum+1);
        for (int i = 0; i < cnt; i++)
        {
            ranNum = numArray[i];
            ssm[count] = common[ranNum];
            count++;
        }

        for(int i =0; i < ssm.Length; i++)
        {
            GameObject.Find("card" + (i + 1)).GetComponent<TextMeshProUGUI>().text = ssm[i];
        }
       
    }

    //https://developer-talk.tistory.com/749
    /*int[] generatorRandomNumber(int min, int max, int count)
    {
        int[] intArray = new int[count];
        Random rand = new Random();

        for (int loop = 0; loop < count; loop++)
        {
            intArray[loop] = rand.Next(min, max);
        }

        return intArray;
    }*/

    int[] getRandomInt(int length, int min, int max) //max포함안함 => (length)<(max-min)이어야함
    {
        int[] randArray = new int[length];
        bool isSame;
        for (int i = 0; i < length; ++i)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max);
                isSame = false;
                for (int j = 0; j < i; ++j)
                {
                    if (randArray[j] == randArray[i])
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame) break;
            }
        }
        return randArray;
    }
}