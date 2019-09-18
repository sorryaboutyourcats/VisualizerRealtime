using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBackground : MonoBehaviour
{
    Color vPurple = new Color32(132, 0, 255, 255);
    Color vGreen = new Color32(0, 255, 0, 255);
    Color vBlue = new Color32(0, 0, 255, 255);
    Color vWhite = new Color32(255, 255, 255, 255);

    void PurpleX()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vPurple);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void GreenX()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vGreen);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void BlueX()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vBlue);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void WhiteX()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vWhite);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void ChangeColor(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
