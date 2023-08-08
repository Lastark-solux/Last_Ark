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
using JetBrains.Annotations;

public class Clipboard : MonoBehaviour 
{
   
    public static int stagenum=1; // stage 관리할 변수 

    public static int 상소문count=0; // 상소문개수 관리할 변수 

    public static string 상소문내용;
    public static int 상소문레벨;
    public static float 최소 ;
    public static float 최대;
    public static int 게이지구분;
    public static float 성공시침식도;
    public static float 성공시희망;
    public static float 성공시식량;
    public static float 성공시인구;
    public static float 실패시침식도;
    public static float 실패시희망;
    public static float 실패시식량;
    public static float 실패시인구;
    public static float 거절시희망;
    public static float 거절시식량;
    public static float 거절시침식도;
    public static float 거절시인구;

    //스토리 상소문 
 
    public static string 스토리타이틀;
    public static string 스토리내용;
    public static string 성공시코멘트;
    public static string 실패시코멘트;
    public static string 거절시코멘트;
    public static int num;
    public static bool Sub1=false;
    public static bool main1 = false;
    public static bool main2 = false;
    public static bool main2_1 = false;
    public static bool main3 = false;
    public static bool main4_1 = false;
    public static bool RayAlive = true;
    public static bool EugeneAlive = true;
    public static bool 시간석1 = false;
    public static bool 시간석2 = false;
    public static bool 시간석3 = false;
    public static bool 깬시간석1 = false;
    public static bool 깬시간석2 = false;
    public static bool 깬시간석3 = false;

    // 뉴스 플래그
    public static bool suc150 = false;
    public static bool fail150 = false;
    public static bool rej150 = false;
    public static bool suc151 = false;
    public static bool fail151 = false;
    public static bool rej151 = false;
    public static bool suc152 = false;
    public static bool fail152 = false;
    public static bool rej152 = false;
    public static bool suc153 = false;
    public static bool fail153 = false;
    public static bool rej153 = false;
    public static bool suc154 = false;
    public static bool fail154 = false;
    public static bool rej154 = false;
    public static bool suc155 = false;
    public static bool fail155 = false;
    public static bool rej155 = false;
    public static bool suc156 = false;
    public static bool fail156 = false;
    public static bool rej156 = false;
    public static bool common1 = false;
    public static bool common2 = false;
    public static bool common3 = false;
    public static bool 침식도엔딩 = false;
    public static bool 인구엔딩 = false;
    public static bool 식량엔딩 = false;
    





    public static List<int> commonSSM = new List<int>();
    public static List<int> specialSSM = new List<int>();
    public static List<int> storySSM = new List<int>();
    public static List<int> dailySSM = new List<int>();
    public static List<int> 조건상소문 = new List<int>();


    public static int maxNum;
    public static int ranNum;
    public static int indexNum;
    public static bool isExit;
    
    public TextMeshProUGUI Scinfo1;
    public GameObject 정무마치기버튼;
   
   





    //public static float 실패확률 = 100 - UI.현희망;
    public static float 실패확률 = 100-UI.현희망;
    public static int A ; // 성공 or 실패 확률 구분 
    public static int B; //특별상소문 일반상소문 구분 일반상소문일 경우 1, 특별상소문은 2, 스토리 상소문일 경우 3
    public static float 게이지; // 불러올게이지
   


    private void Start()
    {

        정무마치기버튼.SetActive(false);
        

    }


    public void 테스트함수()
    {
        List<int> 테스트리스트 = new List<int>();
        테스트리스트.Add(0);
        테스트리스트.Add(1);
        int numbb = 테스트리스트[상소문count];
        print(상소문count);
        pickup기본상소문(numbb);
        print(상소문내용);
        Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
        Scinfo1.text = 상소문내용;
       


        
        
       

    }

    public void 엔딩조건()
    {
        if (UI.현침식도 >= 100)
        {
            침식도엔딩 = true;
            gobadending();

        }
        else if (UI.현인구 <= 1000)
        {
            인구엔딩 = true;
            gobadending();
        }
        else if (UI.현식량 == 0)
        {
            식량엔딩 = true;
            gobadending();
        }
    }
   



    

    public static void gobadending()
    {
            SceneManager.LoadScene("BadEnding");
    }
    public static void gogoodending()
    {
        SceneManager.LoadScene("GoodEnding");
    }
    
    public void 상소문통합함수() //상소문 등장시킬 때 적용할 함수
    {
        int number = dailySSM[상소문count];
       
        print(stagenum);
        print(number);
        if (number<=130)
        {
            pickup기본상소문(number);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
            Scinfo1.text = 상소문내용;

        }
        else if (number >= 150 && number <= 157)
        {
            pickup스토리상소문(number-150);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
         
            Scinfo1.text = 스토리내용;

        }
        else
        {
            pickup특별상소문(number-200);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
            Scinfo1.text = 상소문내용;

        }
       






    }

  /* void Awake() // 초기 한 번만 리스트들 채우기
    {
       
       
        dailySSM.Clear();
        for (int i = 0; i < 130; i++) // 일반상소문
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 8; i++) // 스토리상소문
        {
            storySSM.Add(i + 150);
        }
        for (int i= 0; i<=30;i++)// 특별상소문에서 등장조건이 없는 상소문
        {
            specialSSM.Add(i+200);
        }
        
        데일리리스트(); //처음에 한 번 뽑아줌!

      
       
        
       

    }*/

    public static void 리스트생성()
    {
        for (int i = 0; i < 130; i++) // 일반상소문
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 8; i++) // 스토리상소문
        {
            storySSM.Add(i + 150);
        }
        for (int i = 0; i <= 30; i++)// 특별상소문에서 등장조건이 없는 상소문
        {
            specialSSM.Add(i + 200);
        }
        데일리리스트();
        for (int i = 0; i < dailySSM.Count; i++)
        {
            print(dailySSM[i]);
        }
    }


    private static void pop(List<int> list1, List<int> list2, int index) 
    {
        int num = list1[index];
        list1.RemoveAt(index);
        list2.Add(num);
    }

    private static void peek(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list2.Add(num);
        isExit = true;
    }


    public static void 데일리리스트() // 주어진 상소문을 다 처리했을시 dailyssm을 초기화하고 새로 받아오는 함수 
    {
        
        dailySSM.Clear();
        story();
        common();
        special();
       
       







    }


    public static void common() // 일반상소문 뽑는 함수 
    {
        System.Random random = new System.Random();
        int maxNum = 51;
        if (stagenum == 1)
        {
            maxNum = 50;
        }
        if (stagenum == 2)
        {
            maxNum = 44;
        }
        if (stagenum == 3)
        {
            maxNum = 37;
        }
        if (stagenum == 4)
        {
            maxNum = 30;
        }
        if (stagenum == 5)
        {
            maxNum = 23;
        }
        if (stagenum == 6)
        {
            maxNum = 16;
        }
        if (stagenum == 7)
        {
            maxNum = 66;
        }
        if (stagenum == 8)
        {
            maxNum = 59;
        }
        if (stagenum == 9)
        {
            maxNum = 52;
        }
        if (stagenum == 10)
        {
            maxNum = 45;
        }
        if (stagenum == 11)
        {
            maxNum = 38;
        }
        if (stagenum == 12)
        {
            maxNum = 68;
        }
        if (stagenum == 13)
        {
            maxNum = 61;
        }
        if (stagenum == 14)
        {
            maxNum = 54;
        }
        if (stagenum == 15)
        {
            maxNum = 47;
        }
        if (stagenum == 16)
        {
            maxNum = 40;
        }
        if (stagenum == 17)
        {
            maxNum = 33;
        }
        if (stagenum == 18)
        {
            maxNum = 26;
        }
        if (isExit) // 스토리상소문이 뽑혔으면
        {
            for (int i = 0; i < 6; i++)
            {

                int ranNum = random.Next(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);

            }



        }
        else // 안 뽑혔으면
       
        {
            for (int i = 0; i < 7; i++)
            {


                int ranNum = random.Next(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);

            }
        }
    }


    public static void story()//스토리상소문 뽑는 함수 
    {
        int indexNum = -1;
        isExit = false;

        if (stagenum == 1)
            indexNum = 0;
        else if (stagenum == 7)
            indexNum = 1;
        else if (stagenum == 8 && RayAlive == true)
            indexNum = 2;
        else if (stagenum == 11 && main1==true)
            indexNum = 3;
        else if (stagenum == 14 &&main2_1==true)
            indexNum = 4;
        else if (stagenum == 16 && main3==true)
            indexNum = 5;
        else if (stagenum == 17)
            indexNum = 6;

        if (indexNum >= 0)
        {
            isExit = true;
            peek(storySSM, dailySSM, indexNum);
        }

    }

   
    public static void special() //스페셜 상소문 뽑는 함수 
    {


        if ((100 < UI.현식량)&&(UI.현식량<200))
        {
            if (find(specialSSM, 200))
            {
                조건상소문.Add(200);
            }
        }
        else if ((0 < UI.현식량) && (UI.현식량 <= 100))
        {
            if (find(specialSSM, 201))
            {
                조건상소문.Add(201);
            }
        }
        else if ((80 <=  UI.현침식도) && (UI.현침식도 < 90))
        {
            if (find(specialSSM, 202))
            {
                조건상소문.Add(202);
            }
        }
        else if ((90 <= UI.현침식도) && (UI.현침식도 < 100))
        {
            if (find(specialSSM, 203))
            {
                조건상소문.Add(203);
            }
        }
        else if ((10000 < UI.현인구) && (UI.현인구 < 15000))
        {
            if (find(specialSSM,204))
            {
                조건상소문.Add(204);
            }
            
        }
        else if (UI.현인구<=10000)
        {
            if (find(specialSSM, 205))
            {
                조건상소문.Add(205);
            }
        }
        else if (RayAlive==false)
        {
            if (find(specialSSM, 206))
            {
                조건상소문.Add(206);
            }
        }
        else if (EugeneAlive==false)
        {
            if (find(specialSSM, 207))
            {
                조건상소문.Add(207);
            }
        }

        if (조건상소문.Count>0)
        {
           
            int rannum = Random.Range(0, (조건상소문.Count) - 1);
            int putin = 조건상소문[rannum];
            pop(specialSSM, dailySSM, putin-200);
            조건상소문.Clear();
        }

        else
        {
            
            int rannum = Random.Range(8, (specialSSM.Count) - 1);
            pop(specialSSM, dailySSM, rannum);
        }
        
        


        
    }


    public static bool find( List<int> list1,int number)
    {
        for (int i=0;i<list1.Count; i++)
        {
            if (list1[i]==number)
            {
                return true;
            }
        }
        return false;
    }



    public static void go_ScriptScene()
    {

        SceneManager.LoadScene("Script Scene");

    }


   
    private void pickup기본상소문(int i)
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("기본상소문");
        상소문내용 = data_Dialog[i]["contents"].ToString(); //string으로
        string lv = data_Dialog[i]["level"].ToString();
        상소문레벨 = int.Parse(lv);
        string appsucfood = data_Dialog[i]["AppFood"].ToString();
        성공시식량 = float.Parse(appsucfood);
        string appsuchuman = data_Dialog[i]["AppHuman"].ToString();
        성공시인구 = float.Parse(appsuchuman);//float 형태로 바꾸기
        string appsucdark = data_Dialog[i]["AppDark"].ToString();
       
        성공시침식도 = float.Parse(appsucdark);//float 형태로 바꾸기
        string appsuchope = data_Dialog[i]["AppHope"].ToString();
        성공시희망 = float.Parse(appsuchope);//float 형태로 바꾸기

        string rejectfood = data_Dialog[i]["RejectFood"].ToString();
        거절시식량 = float.Parse(rejectfood);
        string rejecthuman = data_Dialog[i]["RejectHuman"].ToString();
        거절시인구 = float.Parse(rejecthuman);//float 형태로 바꾸기
        string rejectdark = data_Dialog[i]["RejectDark"].ToString();
        거절시침식도 = float.Parse(rejectdark);//float 형태로 바꾸기
        string rejecthope = data_Dialog[i]["RejectHope"].ToString();
        거절시희망 = float.Parse(rejecthope);//float 형태로 바꾸기

        B = 1; // 일반상소문이라는 뜻
    }


   
   

    private void pickup스토리상소문 (int i)
    {
        B = 3;
        num = i + 150;
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("스토리상소문");
        스토리타이틀= data_Dialog[i]["story"].ToString();
        스토리내용 = data_Dialog[i]["content"].ToString();
        성공시코멘트 = data_Dialog[i]["SucCom"].ToString();
        실패시코멘트 = data_Dialog[i]["FailCom"].ToString();
        거절시코멘트 = data_Dialog[i]["RejectCom"].ToString();
        

    }

    
   
    private void pickup특별상소문(int i) //특별상소문의
                                         //게이지 조건을 불러오고 게이지 조건에 맞으면 true를 반환, 아니면 false
                                         //상소문 셔플을 돌려서 false 나오면 다시 돌리고, true가 나올 때 까지 돌리면 될 듯!



    {
            B = 2; // 특별상소문이라는 뜻
            List<Dictionary<string, object>> data_Dialog = CSVReader.Read("특별상소문");
            상소문내용 = data_Dialog[i]["contents"].ToString();
            string appsucfood = data_Dialog[i]["AppSucFood"].ToString();
            성공시식량 = float.Parse(appsucfood);
            string appsuchuman = data_Dialog[i]["AppSucHuman"].ToString();
            성공시인구 = float.Parse(appsuchuman);//float 형태로 바꾸기
            string appsucdark = data_Dialog[i]["AppSucDark"].ToString();
            성공시침식도 = float.Parse(appsucdark);//float 형태로 바꾸기
            string appsuchope = data_Dialog[i]["AppSucHope"].ToString();
            성공시희망 = float.Parse(appsuchope);//float 형태로 바꾸기

            string appfailfood = data_Dialog[i]["AppFailFood"].ToString();
            실패시식량 = float.Parse(appfailfood);
            string appfailhuman = data_Dialog[i]["AppFailHuman"].ToString();
            실패시인구 = float.Parse(appfailhuman);//float 형태로 바꾸기
            string appfaildark = data_Dialog[i]["AppFailDark"].ToString();
            실패시침식도 = float.Parse(appfaildark);//float 형태로 바꾸기
            string appfailhope = data_Dialog[i]["AppFailHope"].ToString();
            실패시희망 = float.Parse(appfailhope);//float 형태로 바꾸기


            string rejectfood = data_Dialog[i]["RejectFood"].ToString();
            거절시식량 = float.Parse(rejectfood);
            string rejecthuman = data_Dialog[i]["RejectHuman"].ToString();
            거절시인구 = float.Parse(rejecthuman);//float 형태로 바꾸기
            string rejectdark = data_Dialog[i]["RejectDark"].ToString();
            거절시침식도 = float.Parse(rejectdark);//float 형태로 바꾸기
            string rejecthope = data_Dialog[i]["RejectHope"].ToString();
            거절시희망 = float.Parse(rejecthope);//float 형태로 바꾸기
       
           

    }




    



    public static void 수락() //상소문 수락시에 적용할 함수 
    {
        if (B==3)
        {
            A = UnityEngine.Random.Range(0, 100);
            if ((0 <= A) && (A <= 실패확률)) //실패하면
            {
                if (num == 150)
                {
                    Sub1 = false;
                    fail150 = true;
                }

                else if (num == 151)
                {
                    RayAlive = false;
                    fail151 = true;
                }
                else if (num == 152)
                {
                    main1 = false;
                    fail152 = true;
                }
                else if (num == 153)
                {
                    main2 = false;
                    fail153 = true;
                }
                else if (num == 154)
                {
                    main3 = false;
                    fail154 = true;
                }
                else if (num == 155)
                {
                    main4_1 = false;
                    fail155 = true;
                }
                else if (num == 156)
                {
                    EugeneAlive = false;
                    fail156 = true;
                }

               
                
            }

            else //성공하면
            {
               
                

                if (num == 150)
                {
                    Sub1 = true;
                    suc150 = true;
                    
                }

                else if (num == 151)
                {
                    RayAlive = true;
                    suc151 = true;
                }
                else if (num == 152)
                {
                    main1 = true;
                    시간석1 = true;
                    suc152 = true;
                }
                else if (num == 153)
                {
                    main2 = true;
                    시간석1 = false;
                    깬시간석1 = true;
                    suc153 = true;
                }
                else if (num == 154)
                {
                    main3 = true;
                    시간석2 = true;
                    suc154 = true;
                }
                else if (num == 155)
                {
                    main4_1 = true;
                    시간석3 = true;
                    suc155 = true;
                }
                else if (num == 156)
                {
                    EugeneAlive = true;
                    suc156 = true;
                }
            }

        }



        else
        {
            if (B == 1) // 일반상소문일 경우 
            {
                UI.Handlegage(1, 성공시희망);
                UI.Handlegage(2, 성공시식량);
                UI.Handlegage(3, 성공시인구);
                UI.Handlegage(4, 성공시침식도);
            }
            else //특별상소문일 경우  성공/ 실패를 계산 
            {

                A = UnityEngine.Random.Range(0, 100);
                if ((0 <= A) && (A <= 실패확률))
                {

                    UI.Handlegage(1, 실패시희망);
                    UI.Handlegage(2, 실패시식량);
                    UI.Handlegage(3, 실패시인구);
                    UI.Handlegage(4, 실패시침식도);
                    Debug.Log("실패");
                    common2 = true;

                }
                else
                {

                    UI.Handlegage(1, 성공시희망);
                    UI.Handlegage(2, 성공시식량);
                    UI.Handlegage(3, 성공시인구);
                    UI.Handlegage(4, 성공시침식도);
                    Debug.Log("성공");
                    common1 = true;


                }

            }
        }
        
        상소문count++;
        print(상소문count);
        Debug.Log(상소문count);



     


    }


    public static void 스크립트진행함수()
    {
        if (stagenum == 1)

        {
            go_ScriptScene();
        }

        else if (stagenum == 3)
        {
            go_ScriptScene();
        }

        else if (stagenum == 6)
        {
            go_ScriptScene();
        }
        else if ((stagenum == 8) && (main1 == true))
        {
            go_ScriptScene();
        }
        else if ((stagenum == 11) && (main2 == true))
        {
            go_ScriptScene();
            시간석2 = false;
            깬시간석2 = true;
        }
        else if ((stagenum == 14) && (main3 == true))
        {
            go_ScriptScene();
            시간석3 = false;
            깬시간석3 = true;
        }
       
        else if (stagenum == 18)
        {
            if ((깬시간석1==true)&& (깬시간석2 == true)&& (깬시간석3 == true)&&(EugeneAlive ==true))
            {
                go_ScriptScene();
            }
            else
            {
                gogoodending();
            }
        }
    }


    public static void 거절() // 거절에 드래그 앤 드롭 하면 적용할 함수 
    {

        if (B == 3)
        {
            if (num == 150)
            {
                Sub1 = false;
                rej150 = true;
                
            }

            else if (num == 151)
            {
                RayAlive = false;
                rej151 = true;
            }
            else if (num == 152)
            {
                main1 = false;
                rej152 = true;
            }
            else if (num == 153)
            {
                main2 = false;
                rej153 = true;
            }
            else if (num == 154)
            {
                main3 = false;
                rej154 = true;
            }
            else if (num == 155)
            {
                main4_1 = false;
                rej155 = true;
            }
            else if (num == 156)
            {
                EugeneAlive = false;
                rej156 = true;
            }

        }
        else
        {
            UI.Handlegage(1, 거절시희망);
            UI.Handlegage(2, 거절시식량);
            UI.Handlegage(3, 거절시인구);
            UI.Handlegage(4, 거절시침식도);
            
            if (B==2)
            {   
                common3 = true;
            }
        
        }
        상소문count++;
        Debug.Log(상소문count);
    }

    public void 정무마치기() // 정무마치기를 눌렀을 시 스테이지가 넘어가면서 스테이지마다 부여되는 게이지 상승값들이 부여됨. // 상소문 count 또한 0으로 초기화가 됨 
    {

        스크립트진행함수();
        stagenum++;
        timecontroller.시간증가();
        UI.gagemechanism();
        상소문count = 0;
        데일리리스트();
        for (int i = 0; i < dailySSM.Count; i++)
        {
            print(dailySSM[i]);
        }

        suc150 = false;
        fail150 = false;
        rej150 = false;
        suc151 = false;
        fail151 = false;
        rej151 = false;
        suc152 = false;
        fail152 = false;
        rej152 = false;
        suc153 = false;
        fail153 = false;
        rej153 = false;
        suc154 = false;
        fail154 = false;
        rej154 = false;
        suc155 = false;
        fail155 = false;
        rej155 = false;
        suc156 = false;
        fail156 = false;
        rej156 = false;
        common1 = false;
        common2 = false;
        common3 = false;
}

    void Update()
    {
        Invoke("버튼활성화", 3f);
        엔딩조건();

    }

    public void 버튼활성화()
    {

        if (상소문count >= 8)
        {
            정무마치기버튼.SetActive(true);
        }
        else
        {
            정무마치기버튼.SetActive(false);
        }
    }
}
