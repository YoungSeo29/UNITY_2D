using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_chaseCamera : MonoBehaviour
{
    void LateUpdate()        //��� �����Ѵ�.(���� ���� ó���� ��������)
    {
        Vector3 pos = this.transform.position;        //�ڽ��� ��ġ
        pos.z = -10;                                  //ī�޶��̹Ƿ� ������ �̵���Ų��
        Camera.main.gameObject.transform.position = pos;
    }
}