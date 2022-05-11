using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //�� ��ȯ�� �ʿ�

public class OnCollision_SwitchScene : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision)    //�浹���� ��
    {
        if (collision.gameObject.name == targetObjectName)      //���� �浹�� ���� �̸��� ��ǥ ������Ʈ���ٸ�
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}