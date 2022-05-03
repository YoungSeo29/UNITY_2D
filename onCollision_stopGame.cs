using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//충돌하면 게임을 정지한다
public class OnCollision_StopGame : MonoBehaviour
{
    public string targetObjectName;

    void Start()
    {
        Time.timeScale = 1;    //시간을 움직인다
    }
     
    void OnCollisionEnter2D(Collision2D collision)     //충돌 발생시
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;      //시간을 멈춘다
        }
    }
}
