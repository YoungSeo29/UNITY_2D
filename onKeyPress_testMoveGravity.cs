using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_TestMoveGravity : MonoBehaviour
{
    public float speed = 3;
    public float jumppower = 8;

    float vx = 0;
    bool leftFlag = false;      //���� �������� ����
    bool pushFlag = false;      //�����̽� Ű�� ������ �ִ��� ����
    bool jumpFlag = false;      //���� �������� ����

    Rigidbody2D rbody;

    void Start()
    {
        //�浹 �ÿ� ȸ����Ű�� ����
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;

        if (Input.GetKey("right"))  //������ Ű�� ������
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))   //���� Ű�� ������
        {
            vx = -speed;     //�������� �̵��ϴ� �̵����� �ִ´�
            leftFlag = true;
        }
        if (Input.GetKey("space"))
        {
            if (pushFlag == false)    //������ ���� ������
            {
                jumpFlag = true;    //���� �غ�
                pushFlag = true;    //������ �ִ� ����
            }
        }
        else
        {
            pushFlag = false;      //������ ���� ����
        }
    }

    void FixedUpdate()
    {
        //�̵��Ѵ�(�߷��� ���� ä)
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        //���� ���������� ������ �ٲ۴�
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;

        //���� ������ ��
        if (jumpFlag)
        {
            jumpFlag = false;
            rbody.addForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
}