using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBackground : MonoBehaviour
{

    [SerializeField] Material color_purple;
    [SerializeField] Material color_green;
    [SerializeField] Material color_blue;
    [SerializeField] Material color_white;

    void PurpleX()
    {
        StartCoroutine(ChangeToPurpleX(0.1f));
    }
    IEnumerator ChangeToPurpleX(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_purple;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void GreenX()
    {
        StartCoroutine(ChangeToGreenX(0.1f));
    }
    IEnumerator ChangeToGreenX(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_green;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void BlueX()
    {
        StartCoroutine(ChangeToBlueX(0.1f));
    }
    IEnumerator ChangeToBlueX(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_blue;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }

    void WhiteX()
    {
        StartCoroutine(ChangeToWhiteX(0.1f));
    }
    IEnumerator ChangeToWhiteX(float colorWait)
    {
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;
        yield return new WaitForSeconds(colorWait);
        Renderer rend = GetComponent<Renderer>();
        rend.material = color_white;
        yield return new WaitForSeconds(colorWait);
        this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
    }
}
