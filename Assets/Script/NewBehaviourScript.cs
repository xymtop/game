using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   public float moveSpeed = 5f; // �ƶ��ٶ�

    private bool moveLeft = false; // �Ƿ������ƶ�
    private bool moveRight = false; // �Ƿ������ƶ�

    void Update()
    {
        if (moveLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (moveRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);        }
    }

}
