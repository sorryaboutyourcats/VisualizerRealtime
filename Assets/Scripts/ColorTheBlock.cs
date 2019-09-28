using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBlock : MonoBehaviour
{
    
    //

    Color vPurple = new Color32(132, 0, 255, 255);
    Color vGreen = new Color32(138, 255, 0, 255);
    Color vBlue = new Color32(0, 180, 255, 255);
    Color vWhite = new Color32(255, 255, 255, 255);

    Renderer blockColor;
    MixerInteractiveExamples.MixerControl mixerControl;

    void Start()
    {
        blockColor = gameObject.GetComponent<Renderer>();
        mixerControl = FindObjectOfType<MixerInteractiveExamples.MixerControl>();
    }

    void RandomColor()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        Color vRandom = new Color32((byte)Random.Range(50, 255), (byte)Random.Range(50, 255), (byte)Random.Range(50, 255), 255);
        ChangeColor(vRandom);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void RandomColorAll()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        ChangeColor(mixerControl.vRandomAll);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void RandomRed()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        Color vRandom = new Color32((byte)Random.Range(200, 255), (byte)Random.Range(50, 150), (byte)Random.Range(50, 150), 255);
        ChangeColor(vRandom);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void RandomGreen()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        Color vRandom = new Color32((byte)Random.Range(50, 150), (byte)Random.Range(200, 255), (byte)Random.Range(50, 150), 255);
        ChangeColor(vRandom);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void RandomBlue()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        Color vRandom = new Color32((byte)Random.Range(50, 150), (byte)Random.Range(50, 150), (byte)Random.Range(200, 255), 255);
        ChangeColor(vRandom);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

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
        blockColor.material.color = color;
    }
}
