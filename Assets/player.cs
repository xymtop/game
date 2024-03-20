using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody rigid;//��Ҹ���
    private Animator animator;//��Ҷ�����
    public Transform mCamera;//������

    private Vector3 moveDir;//�����ƶ�����
    private float currentVelocity = 1;//Ŀǰ��ת���ٶȣ�SmoothDampAngle�����ķ���������
    private float smoothTime = 0.1f;//���ƽ����ʱ�䣨SmoothDampAngle�����Ĳ�����
    public float wSpeed;//�ƶ��ٶ�
    public float rSpeed;//��ת�ٶ�
    public float jPower = 1.0f;//��Ծ����
    private float inputH;//ˮƽ�ƶ�����
    private float inputV;//��ֱ�ƶ�����
    private bool isMove;//�Ƿ��ƶ�
    private bool isRun;//�Ƿ���
    private bool isGround;//�Ƿ��ڵ�����

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        inputH = Input.GetAxis("Horizontal");//��ȡˮƽ/��ֱ�ƶ�����
        inputV = Input.GetAxis("Vertical");
        animator.SetFloat("inputH", inputH);//���¶���������
        animator.SetFloat("inputV", Mathf.Abs(inputV));
        animator.SetBool("isMove", isMove);
        animator.SetBool("isRun", isRun);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGround = false;
            animator.CrossFade("Jump", 0.1f);
            rigid.AddForce(0, jPower, 0);//���������ϵ���
        }//������Ծ����
        if (inputH != 0 || inputV != 0)
        {
            isMove = true;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, (Mathf.Atan2(inputH, inputV) * Mathf.Rad2Deg + mCamera.eulerAngles.y), ref currentVelocity, smoothTime, rSpeed, Time.deltaTime);
        }//�ı����ﳯ��
        else
        {
            isMove = false;
        }//�����ƶ�״̬
        if (Input.GetKey(KeyCode.LeftShift))
        {
            wSpeed = 6;
            isRun = true;
        }//���±���״̬
        else
        {
            wSpeed = 3;
            isRun = false;
        }
        moveDir = mCamera.TransformDirection(inputH, 0, inputV);
        rigid.MovePosition(transform.position + new Vector3(moveDir.x, 0, moveDir.z) * wSpeed * Time.fixedDeltaTime);//�ƶ�����
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isGround)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGround = true;
            }
        }//�ж��Ƿ�ӵ�
    }
            
}
