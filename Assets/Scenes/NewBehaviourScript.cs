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
        if (Input.GetKey(KeyCode.W)) //�����¼����ϵ�W��ʱ��ִ�и�if���
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);//����Ϸ���峯�ŵ�ǰ�������ǰ����10m/s���ٶ�ǰ��
        }
        if (Input.GetKey(KeyCode.S)) //S���İ���
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            //����˶�
        }
        if (Input.GetKey(KeyCode.A)) //A���İ���
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //�����˶�
        }
        if (Input.GetKey(KeyCode.D))//D���İ���
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            //�����˶�
        }

    }
}
