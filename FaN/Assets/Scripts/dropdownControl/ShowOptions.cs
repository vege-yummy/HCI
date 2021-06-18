using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOptions : MonoBehaviour
{
    public GameObject options;

    private bool isShow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickToShowOptions()
    {
        if(!isShow)
        {
            options.SetActive(true);
            isShow = !isShow;
        }
        else
        {
            options.SetActive(false);
            isShow = !isShow;
        }
    }
}
