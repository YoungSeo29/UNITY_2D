using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //씬 전환에 필요

public class OnCollision_SwitchScene : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision)    //충돌했을 때
    {
        if (collision.gameObject.name == targetObjectName)      //만약 충돌한 것의 이름이 목표 오브젝트였다면
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}