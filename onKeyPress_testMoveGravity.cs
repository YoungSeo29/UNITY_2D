using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_TestMoveGravity : MonoBehaviour
{
    public float speed = 3;
    public float jumppower = 8;

    float vx = 0;
    bool leftFlag = false;      //왼쪽 방향인지 여부
    bool pushFlag = false;      //스페이스 키를 누르고 있는지 여부
    bool jumpFlag = false;      //점프 상태인지 여부

    Rigidbody2D rbody;

    void Start()
    {
        //충돌 시에 회전시키지 않음
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;

        if (Input.GetKey("right"))  //오른쪽 키가 눌리면
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))   //왼쪽 키가 눌리면
        {
            vx = -speed;     //왼쪽으로 이동하는 이동량을 넣는다
            leftFlag = true;
        }
        if (Input.GetKey("space"))
        {
            if (pushFlag == false)    //누르고 있지 않으면
            {
                jumpFlag = true;    //점프 준비
                pushFlag = true;    //누르고 있는 상태
            }
        }
        else
        {
            pushFlag = false;      //누르고 있음 해제
        }
    }

    void FixedUpdate()
    {
        //이동한다(중력을 가한 채)
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        //왼쪽 오른쪽으로 방향을 바꾼다
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;

        //만약 점프할 때
        if (jumpFlag)
        {
            jumpFlag = false;
            rbody.addForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
}