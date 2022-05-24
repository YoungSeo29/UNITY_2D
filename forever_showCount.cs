using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//계속 카운터 값을 표시한다
public class forever_showCount : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = GamCounter.value.ToString();
    }
}