using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//터치하면 그 곳에 프리팹을 만든다
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject newPrefab;      //만드는 프리팹 :inspector에 지정

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //터치한 위치를 카메라 안에서의 위치로 변환해서
            var pos = Camera.main.ScreesToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5;            //앞쪽에 표시
            //새로운 프리팹을만들어서 그 위치로 이동시킨다
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;

        }
    }
}