using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ġ�ϸ� �� ���� �������� �����
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject newPrefab;      //����� ������ :inspector�� ����

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //��ġ�� ��ġ�� ī�޶� �ȿ����� ��ġ�� ��ȯ�ؼ�
            var pos = Camera.main.ScreesToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5;            //���ʿ� ǥ��
            //���ο� ������������ �� ��ġ�� �̵���Ų��
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;

        }
    }
}