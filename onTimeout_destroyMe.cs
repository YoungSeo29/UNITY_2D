using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ð��� �� �Ǹ� �ڱ� �ڽ��� �����Ѵ�
public class OnTimeout_DestroyMe : MonoBehaviour
{
    public float limitSec = 3;
    void Start()
    {
        Destroy(this.gameObject, limitSec);       //������ �� �Ŀ� �Ҹ��ϴ� ����
    }
}