using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_countAndHide : MonoBehaviour
{
    //�浹�ϸ� ī���͸� �����ϰ� �ڱ� �ڽ��� �����.
    public string targetObjectName;           //��ǥ ������Ʈ �̸� : Inspector���� ����
    public int addValue = 1;               //������ : Inspector���� ����

    void OnCollisionEnter2D(Collision2D collision)    //�浹���� ��
    {
        //���� �浹�� ���� �̸��� ��ǥ ������Ʈ��
        if (collision.gameObject.name == targetObjectName)
        {
            //ī���� ���� �����Ѵ�
            GameCounter.vlaue = GameCounter.value + addValue;
            //�ڱ� �ڽ��� �����
            this.gameObject.SetActive(false);
        }
    }
}