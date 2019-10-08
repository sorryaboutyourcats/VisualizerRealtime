using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Collections;

public class GrabAvatar : MonoBehaviour
{
    [SerializeField] Texture YourRawImage;
    

    // Start is called before the first frame update
    void Start()
    {
        var fileUrl = "https://raw.githubusercontent.com/IonDen/ion.sound/master/sounds/bell_ring.ogg";
        var fileType = AudioType.OGGVORBIS;
        

        RestClient.Get(new RequestHelper
        {
            Uri = fileUrl,
            DownloadHandler = new DownloadHandlerAudioClip(fileUrl, fileType)
        }).Then(res => {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = ((DownloadHandlerAudioClip)res.Request.downloadHandler).audioClip;
            audio.Play();
        }).Catch(err => {
            EditorUtility.DisplayDialog("Error", err.Message, "Ok");
        });

        StartCoroutine(DownloadImage("https://mixer.com/api/v1/users/267345/avatar"));
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
            YourRawImage = ((DownloadHandlerTexture)request.downloadHandler).texture;
            //YourRawImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
