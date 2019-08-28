using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.ReactiveEffects;

public class ColorTheBlock : MonoBehaviour
{

    [SerializeField] int colorMode = 0;
    [SerializeField] bool activeColoring = false;
    [SerializeField] Material color0_green;

    Color color;
    
    // public bool activeColoring = false;

    void Update()
    {
        if (activeColoring == false)
        {
            print("not changing");
                
        }
        else
            if (colorMode == 0)
            {
                this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = false;

                //Fetch the Renderer from the GameObject
                Renderer rend = GetComponent<Renderer>();

                rend.material = color0_green;
                /*
                //Set the main Color of the Material to green
                rend.material.shader = Shader.Find("_Color");
                rend.material.SetColor("_Color", Color.green);

                //Find the Specular shader and change its Color to red
                rend.material.shader = Shader.Find("Specular");
                rend.material.SetColor("_SpecColor", Color.green);
                */
                activeColoring = false;
                this.GetComponent<MaterialColorIntensityReactiveEffect>().enabled = true;
            StartCoroutine(ChangeColor(2f));
        }
    }

    IEnumerator ChangeColor(float colorWait)
    {
        while (true)
        {
            
        }
    }


}
