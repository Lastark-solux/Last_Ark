using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler     // 도장
{
    public static Vector2 DefaultPos;   // 돌아올 위치

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)  // 드래그 시작
    {
        DefaultPos = this.transform.position;
    }
    void IDragHandler.OnDrag(PointerEventData eventData)    // 드래그 중
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)  // 드래그 끝
    {
        Invoke("Backto", .2f);
    }

    void Backto()
    {
        this.transform.position = DefaultPos;
    }

}
