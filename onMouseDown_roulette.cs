using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*��ġ�ϸ� �귿ó�� ȸ���ϰ� �����*/
public class OnMouseDown_Roulette : MonoBehaviour
{
    public float maxSpeed = 50;   //�ִ� �ӵ�
    float Speed = 0;

    void OnMouseDown()
    {
        Speed = maxSpeed;    //���콺�� Ŭ���ϴ� ���� = �ְ�ӵ��� ����
    }

    void FixedUpdate()
    {
        Speed = Speed * (float)0.97;      //���ǵ带 ���ݾ� �ٿ���
        this.transform.Rotate(0, 0, Speed);     //ȸ���Ѵ�
    }

}