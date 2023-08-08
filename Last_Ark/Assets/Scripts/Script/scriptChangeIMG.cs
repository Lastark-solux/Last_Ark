using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptChangeIMG : MonoBehaviour
{

    public GameObject 집무실, 전쟁, 지도, 암살, 암흑, 어둠, 자살,
        사람혼자, 손, 빛사진, 시간석, 검은화면, 책, 모래시계, 시계, 마을1, 마을2, 광장,
        페이드1, 페이드2, 페이드3, 페이드4;

    public void Start()
    {

        집무실.SetActive(true);
        전쟁.SetActive(false);
        지도.SetActive(false);
        암살.SetActive(false);
        암흑.SetActive(false);
        어둠.SetActive(false);
        자살.SetActive(false);
        사람혼자.SetActive(false);
        손.SetActive(false);
        빛사진.SetActive(false);
        시간석.SetActive(false);
        검은화면.SetActive(false);
        책.SetActive(false);
        모래시계.SetActive(false);
        시계.SetActive(false);
        마을1.SetActive(false);
        마을2.SetActive(false);
        광장.SetActive(false);
        페이드1.SetActive(false);
        페이드2.SetActive(false);
        페이드3.SetActive(false);
        페이드4.SetActive(false);

    }
    public void Update()
    {
        if (ScriptManager.count == 51)
        {
            집무실.SetActive(false);
            전쟁.SetActive(true);
        }
        else if (ScriptManager.count == 54)
        {
            전쟁.SetActive(false);
            지도.SetActive(true);
        }
        else if (ScriptManager.count == 56)
        {
            지도.SetActive(false);
            암살.SetActive(true);
        }
        else if (ScriptManager.count == 59)
        {
            암살.SetActive(false);
            전쟁.SetActive(true);
        }
        else if (ScriptManager.count == 62)
        {
            전쟁.SetActive(false);
            암흑.SetActive(true);
        }
        else if (ScriptManager.count == 69)
        {
            암흑.SetActive(false);
            집무실.SetActive(true);
        }
        else if (ScriptManager.count == 94)
        {
            집무실.SetActive(false);
            어둠.SetActive(true);
        }
        else if (ScriptManager.count == 103)
        {
            어둠.SetActive(false);
            자살.SetActive(true);
        }
        else if (ScriptManager.count == 104)
        {
            자살.SetActive(false);
            어둠.SetActive(true);
        }
        else if (ScriptManager.count == 111)
        {
            어둠.SetActive(false);
            사람혼자.SetActive(true);
        }
        else if (ScriptManager.count == 116)
        {
            사람혼자.SetActive(false);
            손.SetActive(true);
        }
        else if (ScriptManager.count == 118)
        {
            손.SetActive(false);
            빛사진.SetActive(true);
        }
        else if (ScriptManager.count == 123)
        {
            빛사진.SetActive(false);
            집무실.SetActive(true);
        }
        else if (ScriptManager.count == 126)
        {
            집무실.SetActive(false);
            시간석.SetActive(true);
        }
        else if (ScriptManager.count == 133)
        {
            시간석.SetActive(false);
            검은화면.SetActive(true);
        }
        else if (ScriptManager.count == 134)
        {
            검은화면.SetActive(false);
            책.SetActive(true);
        }
        else if (ScriptManager.count == 143)
        {
            책.SetActive(false);
            집무실.SetActive(true);
        }
        else if (ScriptManager.count == 151)
        {
            집무실.SetActive(false);
            모래시계.SetActive(true);
        }
        else if (ScriptManager.count == 155)
        {
            모래시계.SetActive(false);
            시계.SetActive(true);
        }
        else if (ScriptManager.count == 161)
        {
            시계.SetActive(false);
            시간석.SetActive(true);
        }
        else if (ScriptManager.count == 162)
        {
            시간석.SetActive(false);
            마을1.SetActive(true);
        }
        else if (ScriptManager.count == 186)
        {
            마을1.SetActive(false);
            광장.SetActive(true);
        }
        else if (ScriptManager.count == 210)
        {
            광장.SetActive(false);
            집무실.SetActive(true);
        }
        else if (ScriptManager.count == 236)
        {
            집무실.SetActive(false);
            시계.SetActive(true);
        }
        else if (ScriptManager.count == 239)
        {
            시계.SetActive(false);
            모래시계.SetActive(true);
        }
        else if (ScriptManager.count == 240)
        {
            모래시계.SetActive(false);
            마을2.SetActive(true);
        }
        else if (ScriptManager.count == 277)
        {
            마을2.SetActive(false);
            시간석.SetActive(true);
        }
        else if (ScriptManager.count == 283)
        {
            시간석.SetActive(false);
            모래시계.SetActive(true);
        }
        else if (ScriptManager.count == 291)
        {
            모래시계.SetActive(false);
            시계.SetActive(true);
        }
        else if (ScriptManager.count == 296)
        {
            시계.SetActive(false);
            페이드1.SetActive(true);
        }
        else if (ScriptManager.count == 301)
        {
            페이드1.SetActive(false);
            어둠.SetActive(true);
        }
        else if (ScriptManager.count == 314)
        {
            어둠.SetActive(false);
            사람혼자.SetActive(true);
        }
        else if (ScriptManager.count == 315)
        {
            사람혼자.SetActive(false);
            손.SetActive(true);
        }
        else if (ScriptManager.count == 321)
        {
            손.SetActive(false);
            페이드2.SetActive(true);
        }
        else if (ScriptManager.count == 323)
        {
            페이드2.SetActive(false);
            페이드3.SetActive(true);
        }
        else if (ScriptManager.count == 325)
        {
            페이드3.SetActive(false);
            페이드4.SetActive(true);
        }

    }
}
