using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Hide : MonoBehaviour
{
    void onMouseDown()   //터치하면
    {
        this.gameObject.SetActive(false);    //지운다
    }
}