using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MMAreaWithOptions : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject pen1;
    public GameObject pen2;
    public GameObject pen3;

    private int option;
    private int lastoption;
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
        lastoption = option;
        string tmp = dropdown.options[dropdown.value].text;
        option = dropdown.value;
        print(tmp);
        // 0 - 第一个
        // 1 - 第二个
        // 2 - 第三个
        switch (option)
        {
            case 0:
                if(lastoption == 1)
                {
                    pen2.SetActive(false);
                }
                if(lastoption == 2)
                {
                    pen3.SetActive(false);
                }
                pen1.SetActive(true);
                break;
            case 1:
                if (lastoption == 0)
                {
                    pen1.SetActive(false);
                }
                if (lastoption == 2)
                {
                    pen3.SetActive(false);
                }
                pen2.SetActive(true);
                break;
            case 2:
                if (lastoption == 0)
                {
                    pen1.SetActive(false);
                }
                if (lastoption == 1)
                {
                    pen2.SetActive(false);
                }
                pen3.SetActive(true);
                break;
            case 3:
                pen1.SetActive(false);
                pen2.SetActive(false);
                pen3.SetActive(false);
                break;

        }          


    }

}
