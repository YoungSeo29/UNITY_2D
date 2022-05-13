using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometimes_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;    //만드는 프리팹
    public float intervalSec = 1;    //작성 간격

    void Start()
    {
        //지정 초 수마다 CreatePrefab을 반복 실행하는 예약
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);     //CreatePrefab은 메소드 이름
    }

    void CreatePrefab()
    {
        //이 오브젝트의 범위 내에 랜덤으로
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;            //앞 쪽에 표시

        //프리팹을 만든다
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }

}