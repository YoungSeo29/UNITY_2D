using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//시간이 다 되면 자기 자신을 삭제한다
public class OnTimeout_DestroyMe : MonoBehaviour
{
    public float limitSec = 3;
    void Start()
    {
        Destroy(this.gameObject, limitSec);       //지정된 초 후에 소멸하는 예약
    }
}