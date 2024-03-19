using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform body;//����������

    public float maxY = 40;//�����ת�Ͻ���
    public float minY = -10;//�����ת�½���
    public float xSpeed = 250;//���������ת�ٶ�
    public float ySpeed = 125;//���������ת�ٶ�
    private float mouseX;//���ˮƽ�ƶ�����
    private float mouseY;//��괹ֱ�ƶ�����

    void Start()
    {

    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;//�������ˮƽ/��ֱ�ƶ�����
        mouseY += Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
        mouseY = clampAngle(mouseY);
        transform.position = body.position;//������������ƶ�
        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);//�����ת
    }

    private float clampAngle(float angle)
    {
        if (angle < -360)
        {
            angle += 360;
        }
        if (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, minY, maxY);
    }//�������������ת�Ƕ�
}
