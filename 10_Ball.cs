using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // ������Ʈ ��������
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // GetComponent<T> : �ڽ��� TŸ�� ������Ʈ�� ������
    }

    void FixedUpdate()
    {
        // 1. �ӵ� �ٲٱ�
        // velocity : ���� �̵� �ӵ�
        // rigid.velocity = Vector3.right; // ��������. ������ ���Ͱ����θ� �̵�
        rigid.velocity = new Vector3(2, 4, 3); // ���� ����

        // 2. ������ �б�
        // Mass ���� ���� Ŭ���� �����̴µ� �� ���� ���� �ʿ�
        // AddForce(Vec) : Vec�� ����� ũ��� ���� ��
        // ForceMode : ���� �ִ� ���(����, ���� �ݿ�)
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            // Debug.Log(rigid.velocity); // AddForce�� �� �������� ��� �ӵ� velocity ����
        }
        Vector3 vec = new Vector3
            (Input.GetAxisRaw("Horizontal"), 
            0, 
            Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. ȸ���� �ֱ� 
        rigid.AddTorque(Vector3.back); // AddTorque(Vec) : Vec ������ ������ ȸ������ ����
    }       
}
