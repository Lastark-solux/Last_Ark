using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 뉴스 : MonoBehaviour
{
    public GameObject i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i17, i18, i19, i20;
    private void Start()
    {
        i1.SetActive(false);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
        i5.SetActive(false);
        i6.SetActive(false);
        i7.SetActive(false);
        i8.SetActive(false);
        i9.SetActive(false);
        i10.SetActive(false);
        i11.SetActive(false);
        i12.SetActive(false);
        i13.SetActive(false);
        i14.SetActive(false);
        i15.SetActive(false);
        i16.SetActive(false);
        i17.SetActive(false);
        i18.SetActive(false);
        i19.SetActive(false);
        i20.SetActive(false);
    }
    public void Update()
    {
        if (Clipboard.suc150 == true)
        {
            Hide();
            i1.SetActive (true);
        }
        else if (Clipboard.fail150 == true)
        {
            Hide();
            i2.SetActive (true);
        }
        else if (Clipboard.rej150 == true)
        {
            Hide();
            i3.SetActive (true);
        }
        else if (Clipboard.suc151 == true)
        {
            Hide();
            i4.SetActive(true);
        }
        else if (Clipboard.fail151 == true)
        {
            Hide();
            i5.SetActive(true);
        }
        else if (Clipboard.rej151 == true)
        {
            Hide();
            i6.SetActive(true);
        }
        else if (Clipboard.suc152 == true)
        {
            Hide();
            i7.SetActive(true);
        }
        else if (Clipboard.fail152 == true)
        {
            Hide();
            i8.SetActive(true);
        }
        else if (Clipboard.rej152 == true)
        {
            Hide();
            i9.SetActive(true);
        }
        else if (Clipboard.suc153 == true)
        {
            Hide();
            i10.SetActive(true);
        }
        else if (Clipboard.fail153 == true)
        {
            Hide();
            i11.SetActive(true);
        }
        else if (Clipboard.rej153 == true)
        {
            Hide();
            i11.SetActive(true);
        }
        else if (Clipboard.suc154 == true)
        {
            Hide();
            i12.SetActive(true);
        }
        else if (Clipboard.fail154 == true)
        {
            Hide();
            i13.SetActive(true);
        }
        else if (Clipboard.rej154 == true)
        {
            Hide();
            i13.SetActive(true);
        }
        else if (Clipboard.suc155 == true)
        {
            Hide();
            i14.SetActive(true);
        }
        else if (Clipboard.fail155 == true)
        {
            Hide();
            i15.SetActive(true);
        }
        else if (Clipboard.rej155 == true)
        {
            Hide();
            i15.SetActive(true);
        }
        else if (Clipboard.suc156 == true)
        {
            Hide();
            i16.SetActive(true);
        }
        else if (Clipboard.fail156 == true)
        {
            Hide();
            i17.SetActive(true);
        }
        else if (Clipboard.rej156 == true)
        {
            Hide();
            i18.SetActive(true);
        }
        else if (Clipboard.common1 == true)
        {
            Hide();
            i19.SetActive(true);
        }
        else if (Clipboard.common2 == true)
        {
            Hide();
            i20.SetActive(true);
        }
        else if (Clipboard.common3 == true)
        {
            Hide();
            i20.SetActive(true);
        }
    }

    public void Hide()
    {
        i1.SetActive(false);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
        i5.SetActive(false);
        i6.SetActive(false);
        i7.SetActive(false);
        i8.SetActive(false);
        i9.SetActive(false);
        i10.SetActive(false);
        i11.SetActive(false);
        i12.SetActive(false);
        i13.SetActive(false);
        i14.SetActive(false);
        i15.SetActive(false);
        i16.SetActive(false);
        i17.SetActive(false);
        i18.SetActive(false);
        i19.SetActive(false);
        i20.SetActive(false);
    }
}
