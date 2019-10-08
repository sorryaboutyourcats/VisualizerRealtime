﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ImageDownloader : MonoBehaviour
{
    public string url = "https://i.pinimg.com/originals/9e/1d/d6/9e1dd6458c89b03c506b384f537423d9.jpg";
    public Renderer thisRenderer;

    // automatically called when game started
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine()); // execute the section independently

        // the following will be called even before the load finished
        thisRenderer.material.color = Color.red;
    }

    // this section will be run independently
    private IEnumerator LoadFromLikeCoroutine()
    {
        //Debug.Log("Loading ....");
        //WWW wwwLoader = new WWW(url);   // create WWW object pointing to the url
        //yield return wwwLoader;         // start loading whatever in that url ( delay happens here )

        //Debug.Log("Loaded");
        //thisRenderer.material.color = Color.white;              // set white
        //thisRenderer.material.mainTexture = wwwLoader.texture;  // set loaded image

        UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
        thisRenderer.material.color = Color.white;              // set white
        thisRenderer.material.mainTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;
        //YourRawImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture
    }
}