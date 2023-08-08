using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScriptManager : MonoBehaviour
{
    
    public TypeEffect scriptText;
    public TextMeshProUGUI nameText;
    public static bool scriptscene = true, isChoiceDisplayed = false; //스크립트씬인거 확인하기, 화면클릭막기
    public static int count = 0, 선택지count = 0; //상소문 넘버 받아오기

    public GameObject 스칼렛Image, 유진Image, 레이Image;
    public static string story = "sub1", person = "Character";
    public TextMeshProUGUI 선택지1, 선택지2, 선택지3;
    public GameObject 선택지버튼ob1, 선택지버튼ob2, 선택지버튼ob3;
    public Button 선택지bt1, 선택지bt2, 선택지bt3;

    public bool gogoodendingok = false, gorealendingok = false;



    void Start()
    {
        scriptscene = true; 
        scriptText = GameObject.Find("ScriptText").GetComponent<TypeEffect>();
        nameText = GameObject.Find("NameText").GetComponent<TextMeshProUGUI>();
        
        스칼렛Image.SetActive(false);
        유진Image.SetActive(false);
        레이Image.SetActive(false);

        선택지bt1 = GameObject.Find("선택지버튼1").GetComponent<Button>();
        선택지bt2 = GameObject.Find("선택지버튼2").GetComponent<Button>();
        선택지bt3 = GameObject.Find("선택지버튼3").GetComponent<Button>();

        선택지버튼ob1.SetActive(false);
        선택지버튼ob2.SetActive(false);
        선택지버튼ob3.SetActive(false);

        printscript();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //클릭, 스페이스시 프린트스크립트
        {
            if (!isChoiceDisplayed)
            {
                printscript();
                Debug.Log("mmmm프린트스크립트실행mmmmmmmm ");
            }
        }
    }

    public void printscript() //엑셀파일 받아오기
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("스토리 대본");
        Debug.Log(story);
        Debug.Log(data_Dialog[count]["story"].ToString());
        Debug.Log(count);

        if (story == data_Dialog[count]["story"].ToString()) //story 열 값이 바뀌지 않는다면
        {
            if ((person != data_Dialog[count]["person"].ToString())||(count == 147)) //person열 값이 바뀐다면
            {
                if (person == "스칼렛") 스칼렛Image.SetActive(false); //캐릭터 그림 사라지게
                if (person == "유진") 유진Image.SetActive(false);
                if (person == "레이") 레이Image.SetActive(false);
                
                person = data_Dialog[count]["person"].ToString(); //person 갱신
                if (person == "나") 나Action();
                CharacterAction(person); //캐릭터 등장 함수 시행 (이미지, 이름 바꿈)
            }
            string content = data_Dialog[count]["content"].ToString(); //script 불러와서 텍스트 바꿈
            scriptText.SetMsg(content);
        }
        else
        {
            story = data_Dialog[count]["story"].ToString();
            if((count == 324) || (count == 319)) 
            {
                if (gogoodendingok == true) SceneManager.LoadScene("GoodEnding");
                else if (gorealendingok == true) SceneManager.LoadScene("RealEnding");
            }
            else if (count != 50 && count != 93 && count != 159 && count != 290)
            //씬전환 방지, 버튼클릭 후 적용 
            //ex: sub2-1의 첫번째
            {
                count--;
                scriptscene = false;
                SceneManager.LoadScene("Main Scene");
            }
        }
        if (count == 78) //건너뛰기 (ex: sub2-1 >> sub3),
                         //조건: sub2-1 마지막, count: sub3의 첫번째
        {
            count = 84;
        }
        else if (count == 121)
        {
            count = 125;
            //story = "main1";
        }
        else if (count == 214)
        {
            count = 218;
            //story = "main3";
        }
        else
        {
            count++;
            Debug.Log("count++완료 count : " + count);
        }
       
        Debug.Log("현재 count : " + count);
        if (count > 324) SceneManager.LoadScene("Main Scene");
    }

    public void CharacterAction(string name) //캐릭터 그림 올라오고 이름 바뀌게
    {
        nameText.text = name;

        if (name == "스칼렛") 
        {
            스칼렛Image.SetActive(true);
        }
        if (name == "유진") 
        {
            유진Image.SetActive(true);
        }
        if (name == "레이") 
        {
            레이Image.SetActive(true);
        }
    }

    public void 나Action() //선택지 보이게 하는 함수
    {
      
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("선택지");
        string choice1 = data_Dialog[선택지count]["choice1"].ToString();
        선택지1.text = choice1;
        선택지버튼ob1.SetActive(true);
        string choice2 = data_Dialog[선택지count]["choice2"].ToString();
        if (choice2 != "null" && !string.IsNullOrEmpty(choice2))
        {
            선택지2.text = choice2;
            선택지버튼ob2.SetActive(true);
        }
        string choice3 = data_Dialog[선택지count]["choice3"].ToString();
        if (choice3 != "null" && !string.IsNullOrEmpty(choice3))
        {
            선택지3.text = choice3;
            선택지버튼ob3.SetActive(true);
        }
        선택지count++;
        Debug.Log("선택지카운트 : " + 선택지count);
        isChoiceDisplayed = true;

        // 여기서부터 버튼 클릭 시 건너뛰는 코드
        //조건: 분기점의 선택지 번호 count: sub2-2의 첫번째 선택지count: 건너뛰고자 하는 선택지 이전
        if (선택지count == 5)
        {
            Debug.Log("넘어옴");
            선택지bt1.onClick.RemoveAllListeners();
            선택지bt1.onClick.AddListener(() =>
            {
                story = "sub2-1";
                BtnAction();
            });
            선택지bt2.onClick.RemoveAllListeners();
            선택지bt2.onClick.AddListener(() =>
            {
                story = "sub2-2";
                count = 79;
                선택지count = 6;
                BtnAction();
            });
        }
        else if (선택지count == 9)
        {
            Debug.Log("넘어옴");
            선택지bt1.onClick.RemoveAllListeners();
            선택지bt1.onClick.AddListener(() =>
            {
                story = "sub3-1";
                BtnAction();
            });
            선택지bt2.onClick.RemoveAllListeners();
            선택지bt2.onClick.AddListener(() =>
            {
                story = "sub3-2";
                count = 122;
                BtnAction();
            });
        }
        else if (선택지count == 13)
        {
            Debug.Log("넘어옴");
            선택지bt1.onClick.RemoveAllListeners();
            선택지bt1.onClick.AddListener(() =>
            {
                story = "main2-1";
                BtnAction();
                Clipboard.main2_1 = true;
            });
            선택지bt2.onClick.RemoveAllListeners();
            선택지bt2.onClick.AddListener(() =>
            {
                story = "main2-2&3";
                count = 215;
                선택지count = 18;
                BtnAction();
            });
            선택지bt3.onClick.RemoveAllListeners();
            선택지bt3.onClick.AddListener(() =>
            {
                story = "main2-2&3";
                count = 215;
                선택지count = 18;
                BtnAction();
            });
        }
        else if (선택지count == 23)
        {
            Debug.Log("넘어옴");
            선택지bt1.onClick.RemoveAllListeners();
            선택지bt1.onClick.AddListener(() =>
            {
                story = "main4-1&3";
                count = 320;
                BtnAction();
                gogoodendingok = true;
            });
            선택지bt2.onClick.RemoveAllListeners();
            선택지bt2.onClick.AddListener(() =>
            {
                story = "main4-2";
                BtnAction();
                gorealendingok = true;
            });
            선택지bt3.onClick.RemoveAllListeners();
            선택지bt3.onClick.AddListener(() =>
            {
                story = "main4-1&3";
                count = 320;
                BtnAction();
                gogoodendingok = true;
            });
        }
        else
        {
            선택지bt1.onClick.RemoveAllListeners();
            선택지bt1.onClick.AddListener(BtnAction);
            선택지bt2.onClick.RemoveAllListeners();
            선택지bt2.onClick.AddListener(BtnAction);
            선택지bt3.onClick.RemoveAllListeners();
            선택지bt3.onClick.AddListener(BtnAction);
        }
        Debug.Log("나액션끝");
    }
    public void BtnAction()//선택지 버튼 클릭하면 
    {
        선택지버튼ob1.SetActive(false); //숨기기
        선택지버튼ob2.SetActive(false);
        선택지버튼ob3.SetActive(false);
        printscript();
        isChoiceDisplayed = false;
        Debug.Log("BtnAction끝");
    }


}
