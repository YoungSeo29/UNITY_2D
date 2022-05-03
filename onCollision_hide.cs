using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Hide : MonoBehaviour
{
    public string targetObjectName;    //목표 오브젝트 이름
    public string hideObjectName;      //지울 오브젝트 이름

    void Start()
    {
        //처음엔 아무 것도 하지 않음
    }

    void OnCollisionEnter2D(Collison2D collision)
    {
        If(collision.gameObject.name == targetObjectName)          //만약 충돌한 것의 이름이 목표 오브젝트였다면
        {
            GameObject hideObject = GameObject.Fine(hideObjectName);
            hideObject.SetActive(false);                  //삭제함
        }
    }
}