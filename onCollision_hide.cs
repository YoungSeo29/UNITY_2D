using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Hide : MonoBehaviour
{
    public string targetObjectName;    //��ǥ ������Ʈ �̸�
    public string hideObjectName;      //���� ������Ʈ �̸�

    void Start()
    {
        //ó���� �ƹ� �͵� ���� ����
    }

    void OnCollisionEnter2D(Collison2D collision)
    {
        If(collision.gameObject.name == targetObjectName)          //���� �浹�� ���� �̸��� ��ǥ ������Ʈ���ٸ�
        {
            GameObject hideObject = GameObject.Fine(hideObjectName);
            hideObject.SetActive(false);                  //������
        }
    }
}