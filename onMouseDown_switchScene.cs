using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;  //�� ��ȯ�� �ʿ�


public class OnMouseDown_SwitchScene : MonoBehaviour
{
    public string sceneName;

    void OnMouseDown()    //��ġ�ϸ�
    {
        SceneManager.LoadScene(sceneName);      //���� ��ȯ�Ѵ�
    }
}