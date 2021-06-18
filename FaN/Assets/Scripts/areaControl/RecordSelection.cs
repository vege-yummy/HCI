using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RecordSelection : MonoBehaviour
{
    private int[,] mark = new int[813, 688];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MousePositionTrack()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 tmp = Input.mousePosition;
            int x = (int)tmp.x;
            int y = (int)tmp.y;
            int ix = x;
            int iy = y;

            if(x<=1032 && x>=220 && y <= 754 && y >= 67)
            {
                ix = x - 220;
                iy = y - 67;
                mark[ix,iy] = 1;
            }
           

        }
    }
}
