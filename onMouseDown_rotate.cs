using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*��ġ�ϸ� ȸ���Ѵ�*/
public class OnMouseDown_Rotate : MonoBehaviour
{
    public float angle = 360;
    float rotateAngle = 0;

    void OnMouseDown()     //��ġ�ϸ�
    {
        rotateAngle = angle;   //ȸ�������� ����
    }

    void OnMouseUp()    //��ġ�� �׸��θ�
    {
        rotateAngle = 0;   //ȸ�������� 0���� �Ѵ�(ȸ�� ����)
    }

    void FixedUpdate()    //��� �����Ѵ�(���� �ð�����)
    {
        this.transform.Rotate(0, 0, rotateAngle / 50);     //���� ������ ȸ���Ѵ�
    }
}