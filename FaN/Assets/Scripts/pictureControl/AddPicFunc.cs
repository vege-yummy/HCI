using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPicFunc : MonoBehaviour
{
    public Image tarimage;
    public GameObject TarRawImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickToAddPic()
    {
        TarRawImage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
