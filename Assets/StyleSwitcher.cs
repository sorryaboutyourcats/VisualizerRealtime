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
        if (Input.GetKeyDown(KeyCode.B))
        {
            BroadcastMessage("Blue");
        }
    }
}