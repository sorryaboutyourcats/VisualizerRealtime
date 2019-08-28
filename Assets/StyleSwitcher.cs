using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleSwitcher : MonoBehaviour
{


    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            BroadcastMessage("Green");
        }
    }

    void Green()
    {
    }

    /*
    void Update()
    {
        Green();
    }

    void Green()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            print("g");

            ColorTheBlock colorTheBlock = GetComponent<ColorTheBlock>();
            
            ColorTheBlock.activeColoring = true;
            
            
        }
    }
    */

}
