using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SkyWithOptions : MonoBehaviour
{
    public Dropdown dropdown;
    private int option;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickToGetOption()
    {
        string tmp =  dropdown.options[dropdown.value].text;
        option = dropdown.value;
        print(tmp);
        // 0 - 第一个
        // 1 - 第二个
        // 2 - 第三个
        sendPostWithOptions(option);
    }
    public void sendPostWithOptions(int i)
    {
        string url = "http://192.168.43.141:5000/sky_segmentation";
        string pic = "data:image/jpeg;base64,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";

        WWWForm form = new WWWForm();
        form.AddField("option", i);
        form.AddField("picture", pic);

        StartCoroutine(SendPost(url, form));
    }
    IEnumerator SendPost(string url, WWWForm wForm)
    {
        UnityWebRequest request = UnityWebRequest.Post(url, wForm);
        yield return request.SendWebRequest();
        if (request.isHttpError || request.isNetworkError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            string receiveContent = request.downloadHandler.text;
            Debug.Log(receiveContent);
        }
    }
}
