using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class three_run : MonoBehaviour
{
    public float speed = 0.1f; //����һ���ٶ�
    public float run = 0.5f;
    void Update()
    {
        //����������ƶ�
        transform.Translate(0, 0, speed * Input.GetAxis("Vertical"));
        transform.Rotate(0, speed * 20 * Input.GetAxis("Horizontal"), 0);
        //ʵ����Ծ��Ч��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 6000);
        }
        //��ֹ���嵹�£�����ǽ�ɫ����������ֱ����������
        if ((this.transform.eulerAngles.x > 90 && this.transform.eulerAngles.x < 270) || (this.transform.eulerAngles.z > 90 && this.transform.eulerAngles.z < 270))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
