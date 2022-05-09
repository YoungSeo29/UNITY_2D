using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*충돌하면 표시한다(여러개 대응)*/
public class onMultiCollision_show : MonoBehavior
{
    public string targetObjectName;
    public string showObjectName;

    GameObject showObject;
    float orgY = 0;
    float ofsetY = 10000;    //이 값을 Y방향에 더하는 것으로 지운다. 

    void Start()
    {
        showObject = GameObject.Find(showObjectName);    //지우기 전에 표시 오브젝트를 기억해 둠 
        //지운다. (showObject.SetActive(false);대신
        orgY = showObject.transform.position.y;    
        if (orgY > ofsetY) 
        {
            orgY -= ofsetY;
        }

        Vector3 pos = showObject.transform.position;
        pos.y = orgY + ofsetY;
        showObject.trnasfomr.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)       //만약 충돌한 것의 이름이 목표 오브젝트라면
        {
            Vector3 pos = showObject.transform.position;    //표시(showObject.SetActive(true);대신

            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }

}