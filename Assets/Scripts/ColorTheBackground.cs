using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBackground : MonoBehaviour
{

    Color vPurple = new Color32(132, 0, 255, 255);
    Color vGreen = new Color32(138, 255, 0, 255);
    Color vBlue = new Color32(0, 180, 255, 255);
    Color vWhite = new Color32(255, 255, 255, 255);

    Renderer blockColor;
    MeshRenderer backgroundBlock;

    void Start()
    {
        backgroundBlock = GetComponent<MeshRenderer>();
        blockColor = gameObject.GetComponent<Renderer>();
    }

    void RandomBackgroundColor()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        Color vRandom = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        ChangeColor(vRandom);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void PurpleX()
    {
        StartCoroutine(ChangeColorr(0.0000000000000001f, vPurple));
//        ChangeColor(vPurple);
    }

    IEnumerator ChangeColorr(float waitTime, Color color)
    {
        backgroundBlock.enabled = false;
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        blockColor.material.color = color;
        yield return new WaitForSeconds(waitTime);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
        backgroundBlock.enabled = true;
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
        blockColor.material.color = color;
    }
}
