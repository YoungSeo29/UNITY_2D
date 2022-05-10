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

    void Start()    //처음 시행한다 
    {
        nowMode = downAnime;
    }

    void Update()     //계속 시행한다
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

    void FixedUpdate()     //계속 시행한다(일정 시간마다)
    {
        this.GetComponent<Animator>().Play(nowMode);
    }

}