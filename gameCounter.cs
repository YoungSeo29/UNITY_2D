using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ī���� ��ü
public class gameCounter : MonoBehaviour
{

    public static int value; // �����ϴ� ī������ ��

    public int startCount = 0; // ī���� �ʱ갪 : Inspector�� ����

    void Start()// ó���� �����Ѵ�
    {
        value = startCount;// ī���͸� ����...���ϸ� ���÷��� �Ҷ� ������ ������ ������ 
    }
}
