using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Flip : MonoBehaviour
{
    public int maxCount = 50;
    int count = 0;
    bool flipFlag = false;

    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        count = count + 1;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, 180);  //180도 회전해서 돈다 
            count = 0;
            //그림이 180도 회전하므로 위, 아래를 반전시킨다.
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}
