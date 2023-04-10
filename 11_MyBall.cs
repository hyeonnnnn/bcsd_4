using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    // �ݶ��̴�: ���� ������Ʈ�� ��� ����

    // OnTriggerEnter: �ݶ��̴� �浹�� ������ �� ȣ��Ǵ� �Լ�
    // OnTriggerStay: �ݶ��̴��� ��� �浹�ϰ� ���� ��
    // OnTriggerExit: �ݶ��̴� �浹�� ���� ��
    private void OnTriggerStay(Collider other) // ť�� ���� ���� ��
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse); // ���� �ö󰡵��� ���� ����
    }
}
