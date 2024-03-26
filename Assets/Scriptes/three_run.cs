using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class three_run : MonoBehaviour
{
    public float speed = 0.1f; //定义一个速度
    public float run = 0.5f;
    void Update()
    {
        //控制物体的移动
        transform.Translate(0, 0, speed * Input.GetAxis("Vertical"));
        transform.Rotate(0, speed * 20 * Input.GetAxis("Horizontal"), 0);
        //实现跳跃的效果
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 6000);
        }
        //防止物体倒下（如果是角色控制器可以直接面板调整）
        if ((this.transform.eulerAngles.x > 90 && this.transform.eulerAngles.x < 270) || (this.transform.eulerAngles.z > 90 && this.transform.eulerAngles.z < 270))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
