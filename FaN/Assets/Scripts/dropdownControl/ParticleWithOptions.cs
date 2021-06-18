using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleWithOptions : MonoBehaviour
{
    public Dropdown dropdown;
    private int option;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void clickToGetOption()
    {
        string tmp = dropdown.options[dropdown.value].text;
        option = dropdown.value;
        print(tmp);
        // 0 - 第一个
        // 1 - 第二个
        // 2 - 第三个
    }
   
}
