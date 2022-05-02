using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*��� ���Ѿ� ����*/
public class Forever_Chase : MonoBehaviour
{
    public string targetObjectName;  //��ǥ ������Ʈ �̸� : Instpector���� ����
    public float speed = 1;     //�ӵ� : Instpector���� ����

    GameObject targetObject;
    Rigidbody2D rbody;

    void Start()   //ó���� �����Ѵ�
    {
        //��ǥ ������Ʈ�� ã�Ƴ���
        targetObject = GameObject.Fine(targetObjectName);
        //�߷��� 0���� �ؼ� �浹 �ÿ� ȸ����Ű�� �ʴ´�
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()    //��� �����Ѵ�. �����ð����� 
    {
        //������Ʈ ������ �����ؼ�
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
        //�� ���⿡�� ������ ������ ���ư���
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);
        //�̵� ������ ���ʿ��� ���������� �ٲ۴�
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
}