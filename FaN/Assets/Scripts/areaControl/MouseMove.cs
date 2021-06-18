using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseMove : MonoBehaviour
{
    private void Update()
    {
        //自身坐标转换成屏幕坐标
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //让鼠标的屏幕坐标与对象坐标一致
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pos.z);
        //转换成世界坐标
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.GetMouseButton(0))
        {
            print(Input.mousePosition);
        }
    }

}
