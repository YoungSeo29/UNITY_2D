using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*계속 뒤쫓아 간다*/
public class Forever_Chase : MonoBehaviour
{
    public string targetObjectName;  //목표 오브젝트 이름 : Instpector에서 지정
    public float speed = 1;     //속도 : Instpector에서 지정

    GameObject targetObject;
    Rigidbody2D rbody;

    void Start()   //처음에 시행한다
    {
        //목표 오브젝트를 찾아낸다
        targetObject = GameObject.Fine(targetObjectName);
        //중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()    //계속 시행한다. 일정시간마다 
    {
        //오브젝트 방향을 조사해서
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
        //그 방향에서 지정한 양으로 나아간다
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);
        //이동 방향을 왼쪽에서 오른쪽으로 바꾼다
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
}