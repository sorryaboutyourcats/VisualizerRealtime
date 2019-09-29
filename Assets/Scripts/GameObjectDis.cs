using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectDis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InteractivityManager = GameObject.FindGameObjectWithTag("MixPlay");
    }
    public void HideGameObject()
    {
        if (InteractivityManager.activeInHierarchy)
        {
            InteractivityManager.SetActive(false);
        }
        else
        {
            InteractivityManager.SetActive(true);
        }
    }
    public GameObject InteractivityManager;





    // Update is called once per frame
    void Update()
    {
        
    }
}
