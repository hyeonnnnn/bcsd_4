using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    void Update() 
    {
        if (Input.anyKeyDown) // �ƹ� �Է��� ���ʷ� ���� �� true
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.anyKey) // �ƹ� �Է��� ������ true
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        // �� �Է� �Լ��� 3������ ���� (Down, Stay, Up)

        // GetKey: Ű���� ��ư �Է��� ������ true

        if (Input.GetKeyDown(KeyCode.Return)) // Return == Enter
            Debug.Log("�������� �����߽��ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");

        // GetMouse: ���콺 ��ư �Է��� ������ true

        if (Input.GetMouseButtonDown(0)) // 0: ����, 1: ������
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��..");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

        // GetButton : Input ��ư �Է� ������ true

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��..");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");

        // GetAxis : ����, ���� ��ư �Է��� ������ float

        if (Input.GetButton("Horizontal")) {
            Debug.Log("Ⱦ �̵� ��.." 
                + Input.GetAxisRaw("Horizontal")); // ����ġ X, GetAxisRaw: ����ġ O
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��.."
                + Input.GetAxisRaw("Vertical"));
        }
    }
    
}

