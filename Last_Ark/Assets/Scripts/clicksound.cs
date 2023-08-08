using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicksound : MonoBehaviour
{
    public AudioSource clicksound1, clicksound2;
    void Start()
    {
        clicksound1 = GetComponent<AudioSource>();
        clicksound2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Clicksound()
    {
        clicksound1.Play();
        clicksound2.Play();
    }
}
