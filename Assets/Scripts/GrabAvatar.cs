using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GrabAvatar : MonoBehaviour
{
    string url = "https://mixer.com/api/v1/users/";
    public Renderer thisRenderer;

    public void start()
    {
    }

    public void AvatarOn(int userID)
    {
        StartCoroutine(AvatarON(userID));
    }

    public void AvatarOff()
    {
        Color coco = new Color(1, 1, 1, 0);
        gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", coco);
    }

    private IEnumerator AvatarON(int userID)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(url + userID + "/avatar");
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
            thisRenderer.material.mainTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;
        Color coco = new Color(1, 1, 1, 0.3f);
        gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", coco);
    }


}