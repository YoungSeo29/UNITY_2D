using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�浹�ϸ� ������ �����Ѵ�
public class OnCollision_StopGame : MonoBehaviour
{
    public string targetObjectName;

    void Start()
    {
        Time.timeScale = 1;    //�ð��� �����δ�
    }
     
    void OnCollisionEnter2D(Collision2D collision)     //�浹 �߻���
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;      //�ð��� �����
        }
    }
}
