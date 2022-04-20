using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_rotate : MonoBehaviour 
{

    public float angle = 90;

    void FixedUpdate()
    {
        this.transform.Translate(0, 0, angle / 50);
    }

}