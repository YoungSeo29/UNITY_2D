using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카운터 본체
public class gameCounter : MonoBehaviour
{

    public static int value; // 공유하는 카운터의 값

    public int startCount = 0; // 카운터 초깃값 : Inspector에 지정

    void Start()// 처음에 시행한다
    {
        value = startCount;// 카운터를 리셋...안하면 리플레이 할때 누적된 값으로 시작함 
    }
}
