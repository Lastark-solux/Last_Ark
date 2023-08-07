using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OpenPanel : MonoBehaviour
{
    public RectTransform newsPanel, rockPanel, stampPanel, scriptPanel, Panel; 
    
    public void PanelBtn(string panelName)
    {
        if (panelName == "News")
        {
            if (newsPanel.localPosition.x == 715)
            {
                newsPanel.DOLocalMoveX(55, 2f).SetEase(Ease.OutBack);
            }
            else if (newsPanel.localPosition.x == 55)
            {
                newsPanel.DOLocalMoveX(715, 2f).SetEase(Ease.InBack);
            }
        }

        else if (panelName == "Rock")
        {
            if (rockPanel.localPosition.x == 550)
            {
                rockPanel.DOLocalMoveX(335, 2f).SetEase(Ease.OutBack);
            }
            else if (rockPanel.localPosition.x == 335)
            {
                rockPanel.DOLocalMoveX(550, 1f).SetEase(Ease.InBack);
            }
        }

        else if (panelName == "Stampbox")
        {
           stampPanel.DOLocalMoveX(323, 2f).SetEase(Ease.OutBack);
        }

        else if (panelName == "Quit")
        {
            Panel.DOLocalMoveX(742, 2f).SetEase(Ease.InBack);
        }

        else if (panelName == "Script")
        {
            scriptPanel.DOLocalMoveY(20, 2f).SetEase(Ease.OutBack);
        }
    }
}
