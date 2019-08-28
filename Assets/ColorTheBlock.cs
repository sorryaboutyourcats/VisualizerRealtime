using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBlock : MonoBehaviour
{

    [SerializeField] Material color_green;
    [SerializeField] Material color_blue;

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


}
