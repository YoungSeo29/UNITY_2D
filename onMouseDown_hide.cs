using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Hide : MonoBehaviour
{
    void onMouseDown()   //��ġ�ϸ�
    {
        this.gameObject.SetActive(false);    //�����
    }
}