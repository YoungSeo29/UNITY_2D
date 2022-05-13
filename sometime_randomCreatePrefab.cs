using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometimes_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;    //����� ������
    public float intervalSec = 1;    //�ۼ� ����

    void Start()
    {
        //���� �� ������ CreatePrefab�� �ݺ� �����ϴ� ����
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);     //CreatePrefab�� �޼ҵ� �̸�
    }

    void CreatePrefab()
    {
        //�� ������Ʈ�� ���� ���� ��������
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;            //�� �ʿ� ǥ��

        //�������� �����
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }

}