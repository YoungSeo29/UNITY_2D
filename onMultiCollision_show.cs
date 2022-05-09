using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*�浹�ϸ� ǥ���Ѵ�(������ ����)*/
public class onMultiCollision_show : MonoBehavior
{
    public string targetObjectName;
    public string showObjectName;

    GameObject showObject;
    float orgY = 0;
    float ofsetY = 10000;    //�� ���� Y���⿡ ���ϴ� ������ �����. 

    void Start()
    {
        showObject = GameObject.Find(showObjectName);    //����� ���� ǥ�� ������Ʈ�� ����� �� 
        //�����. (showObject.SetActive(false);���
        orgY = showObject.transform.position.y;    
        if (orgY > ofsetY) 
        {
            orgY -= ofsetY;
        }

        Vector3 pos = showObject.transform.position;
        pos.y = orgY + ofsetY;
        showObject.trnasfomr.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)       //���� �浹�� ���� �̸��� ��ǥ ������Ʈ���
        {
            Vector3 pos = showObject.transform.position;    //ǥ��(showObject.SetActive(true);���

            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }

}