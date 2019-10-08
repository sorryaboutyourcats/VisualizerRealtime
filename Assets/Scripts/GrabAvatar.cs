using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GrabAvatar : MonoBehaviour
{
    string url = "https://mixer.com/api/v1/users/";
    public Renderer thisRenderer;
    bool rotate;

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

    public void AvatarRandomRotateOn()
    {
        rotate = true;
        StartCoroutine(AvatarRandomRotateON());
    }

    private IEnumerator AvatarRandomRotateON()
    {
        float speed = Random.Range(0.1f, 10f);
        while (rotate == true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed);
            yield return null;
        }
    }

    public void AvatarRandomRotateOff()
    {
        rotate = false;
    }

    public void AvatarColorMess()
    {
        gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_ColorMask", Random.Range(2f, 13.99f));
    }

    public void AvatarColorReset()
    {
        gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_ColorMask", 15);
    }

    public void AvatarRandomAlpha()
    {
        Color coco = new Color(1, 1, 1, Random.Range(0.1f, 1f));
        gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", coco);
    }

}