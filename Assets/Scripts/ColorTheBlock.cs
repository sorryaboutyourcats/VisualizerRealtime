using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBlock : MonoBehaviour
{

    [SerializeField] Material color_green;
    [SerializeField] Material color_blue;
    [SerializeField] Material color_white;

    Color vPurple = new Color32(132, 0, 255, 255);

    //void Start()
    //{
    //    Color vPurple = new Color32(132, 0, 255, 255);
    //}

    void Purple()
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
//        ChangeColor(132f, 0f, 255f);
        ChangeColorr(vPurple);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void ChangeColor(float r, float g, float b)
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(r / 255f, g / 255f, b / 255f);
    }

    void ChangeColorr(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    void Green()
    {
        StartCoroutine(ChangeToGreen(0.1f));
    }
    IEnumerator ChangeToGreen(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_green;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void Blue()
    {
        StartCoroutine(ChangeToBlue(0.1f));
    }
    IEnumerator ChangeToBlue(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_blue;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void White()
    {
        StartCoroutine(ChangeToWhite(0.1f));
    }
    IEnumerator ChangeToWhite(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_white;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }
}
