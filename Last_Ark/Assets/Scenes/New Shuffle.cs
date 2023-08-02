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

public class NewShuffle : MonoBehaviour
{

    //각각 기본상소문 초기 리스트, 특별상소문 초기 리스트, 당일 상소문의 리스트이다.
    //작동방식은 특별상소문을 플래그에 따라 뽑고, 나머지 칸을 기본상소문의 번호에서 뽑아온다.
    //작동방식에 따라 public 및 변수 이름 변경
    List<int> commonSSM = new List<int>();
    List<int> specialSSM = new List<int>();
    List<int> dailySSM = new List<int>();

    int maxNum, ranNum, indexNum;

    int yy = 2023;
    int mm = 1;
    int m_count = 1;
    GameObject gameDate;

    bool isExit;

    // 씬 동작을 시작할 때 나오는 함수
    void Start()
    {
        this.gameDate = GameObject.Find("Date"); //날짜 변경 TEXT오브젝트를 받아옴. 오브젝트 이름 변경 가능. 이때 TEXT가 아닐경우 대상 오브젝트 형 변환해야.

        for (int i = 0; i < 200; i++) //200은 보통 상소문 개수, 상소문 개수 변경이 변동
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 7; i++) //7은 처음 상정된 특별 상소문 개수, 이때 번호가 150~156이라 +150.
        {
            specialSSM.Add(i+150);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBtn()
    {
        //버튼 클릭시 우선 이전의 상소문 리스트를 전부 비운다
        dailySSM.Clear();

        print("버튼 클릭");
        date_ctr();
        special();
        common();
        daily();
    }

    //list1에서 해당되는 index의 요소를 뽑아 list2로 옮겨주는 함수, 기본 상소문에 쓰인다
    void pop(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list1.RemoveAt(index);
        list2.Add(num);
    }

    //list1에서 해당되는 index의 요소를 list2로 복제해주는 함수, 특수 상소문에 쓰인다
    void peek(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list2.Add(num);
        isExit = true;
    }

    //기본 리스트에서 인덱스 번호를 랜덤으로 뽑아 당일 리스트에 넣는 함수, 뽑힌 번호는 기본 리스트에서 삭제
    void common()
    {
        if (isExit)
        {
            for (int i = 0; i < 7; i++)
            {
                maxNum = commonSSM.Count;
                ranNum = Random.Range(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);
            }
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                maxNum = commonSSM.Count;
                ranNum = Random.Range(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);
            }
        }
    }
    
    //플래그에 따라 당일 리스트에 넣는 함수. 한달 당 최대1개만 들어갈 수 있다.
    //플래그에 따라 번호를 당일 리스트에 복제하여 넣는다
    void special()
    {
        indexNum = -1;
        isExit = false;

        if (m_count == 1)
            indexNum = 0;
        else if (m_count == 7)
            indexNum = 1;
        else if (m_count == 8 /*&& RayAlive*/)
            indexNum = 2;
        else if (m_count == 11 /*&& main1*/)
            indexNum = 3;
        else if (m_count == 14 /*&& main2_1*/)
            indexNum = 4;
        else if (m_count == 16 /*&& main3*/)
            indexNum = 5;
        else if (m_count == 17)
            indexNum = 6;

        if (indexNum>=0)
        {
            peek(specialSSM, dailySSM, indexNum);
        }

    }

    void daily()
    {
        if(dailySSM.Count != 8)
        {
            print("Error");
        }
        //오브젝트 찾아서 텍스트 바꾸기, 여기서는 번호로 대치함
        for (int i = 0; i < dailySSM.Count; i++)
        {
            GameObject.Find("card" + (i + 1)).GetComponent<TextMeshProUGUI>().text = Convert.ToString(dailySSM[i]);
        }
    }

    void date_ctr() //날짜 바꿔주는 함수
    {
        mm++;
        m_count++;
        if (mm > 12)
        {
            mm = 1;
            yy++;
        }

        /*날짜에 따른 레벨 부울. 이전에 있었음 혹시 몰라 주석처리
        if (mm >= 6) second_level = true;
        if (mm >= 12) third_level = true;
        */

        if (mm >= 10) //텍스트 변경
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". " + mm + ". 01";
        }
        else
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". 0" + mm + ". 01";
        }
    }

}
