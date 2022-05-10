using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime : MonoBehaviour
{
    public string upAnime;
    public string downAnime;
    public string rightAnime;
    public string leftAnime;

    string nowMode = "";

    void Start()    //ó�� �����Ѵ� 
    {
        nowMode = downAnime;
    }

    void Update()     //��� �����Ѵ�
    {
        if (input.GetKey("up"))
        {
            nowMode = upAnime;
        }
        if (input.GetKey("down"))
        {
            nowMode = downAnime;
        }
        if (input.GetKey("right"))
        {
            nowMode = rightAnime;
        }
        if (input.GetKey("left"))
        {
            nowMode = leftAnime;
        }
    }

    void FixedUpdate()     //��� �����Ѵ�(���� �ð�����)
    {
        this.GetComponent<Animator>().Play(nowMode);
    }

}