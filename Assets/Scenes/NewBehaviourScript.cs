using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ 
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //当按下键盘上的W键时，执行该if语句
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);//让游戏物体朝着当前坐标轴的前方以10m/s的速度前进
        }
        if (Input.GetKey(KeyCode.S)) //S键的按下
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            //向后运动
        }
        if (Input.GetKey(KeyCode.A)) //A键的按下
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //向左运动
        }
        if (Input.GetKey(KeyCode.D))//D键的按下
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            //向右运动
        }

    }
}
