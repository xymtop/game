using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   public float moveSpeed = 5f; // 移动速度

    private bool moveLeft = false; // 是否向左移动
    private bool moveRight = false; // 是否向右移动

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
