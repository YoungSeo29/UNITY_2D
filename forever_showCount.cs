using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//��� ī���� ���� ǥ���Ѵ�
public class forever_showCount : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = GamCounter.value.ToString();
    }
}