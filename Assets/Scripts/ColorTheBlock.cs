using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBlock : MonoBehaviour
{

    Color vPurple = new Color32(132, 0, 255, 255);
    Color vGreen = new Color32(0, 255, 0, 255);
    Color vBlue = new Color32(0, 0, 255, 255);
    Color vWhite = new Color32(255, 255, 255, 255);

    void Purple()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vPurple);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void Green()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vGreen);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void Blue()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(vBlue);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void White()
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
