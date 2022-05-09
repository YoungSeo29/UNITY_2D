using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*터치하면 룰렛처럼 회전하고 멈춘다*/
public class OnMouseDown_Roulette : MonoBehaviour
{
    public float maxSpeed = 50;   //최대 속도
    float Speed = 0;

    void OnMouseDown()
    {
        Speed = maxSpeed;    //마우스로 클릭하는 순간 = 최고속도를 낸다
    }

    void FixedUpdate()
    {
        Speed = Speed * (float)0.97;      //스피드를 조금씩 줄여서
        this.transform.Rotate(0, 0, Speed);     //회전한다
    }

}