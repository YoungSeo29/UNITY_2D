using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*터치하면 회전한다*/
public class OnMouseDown_Rotate : MonoBehaviour
{
    public float angle = 360;
    float rotateAngle = 0;

    void OnMouseDown()     //터치하면
    {
        rotateAngle = angle;   //회전각도를 지정
    }

    void OnMouseUp()    //터치를 그만두면
    {
        rotateAngle = 0;   //회전각도를 0으로 한다(회전 멈춤)
    }

    void FixedUpdate()    //계속 시행한다(일정 시간마다)
    {
        this.transform.Rotate(0, 0, rotateAngle / 50);     //지정 각도로 회전한다
    }
}