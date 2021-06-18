using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIDrawLine : MonoBehaviour
{
    public LineRenderer line;
    public Canvas canvas;
    private float canvasScaler;     //画布的缩放比例
    private List<Vector3> linePos = new List<Vector3>();    //存储线的位置点

    private void Start()
    {
        Init();
    }

    /// <summary>
    /// 初始化
    /// </summary>

    void Init()
    {
        canvasScaler = canvas.transform.localScale.x;
        line.startWidth = 0.08f;
        line.endWidth = 0.08f;
    }

    /// <summary>
    /// 画线
    /// </summary>

    void DrawLine()
    {
        line.positionCount = linePos.Count;
        line.SetPositions(linePos.ToArray());
    }

    Vector3 value;

    private Vector3 InputConvert(Vector3 _vec)
    {
        value.z = 1;
        value.x = (_vec.x - Screen.width / 2f) * canvasScaler;
        value.y = (_vec.y - Screen.height / 2f) * canvasScaler;
        return value;
    }

    /// <summary>
    /// 鼠标按下
    /// </summary>

    public void OnPointerDown()
    {
        //Debug.Log("Down");
        line.positionCount = 0;
        linePos.Clear();
        linePos.Add(InputConvert(Input.mousePosition));
    }

    /// <summary>
    /// 鼠标拖拽
    /// </summary>

    public void OnDrag()
    {
        //Debug.Log("Drag");
        linePos.Add(InputConvert(Input.mousePosition));
        line.positionCount = linePos.Count;
        line.SetPositions(linePos.ToArray());
    }

    /// <summary>
    /// 鼠标释放
    /// </summary>

    public void OnPointerUp()
    {
        //Debug.Log("Up");
        line.positionCount = 0;
    }

}