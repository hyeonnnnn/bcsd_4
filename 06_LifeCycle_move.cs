using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        // Transform : ������Ʈ ���¿� ���� �⺻ ������Ʈ
        // ������Ʈ�� ���� Transform�� �׻� ������ ����
        // ������ �ʿ� X

        // Translate : ���� ���� '���� ��ġ�� ���ϴ�' �Լ�

        // Vector3 vec = new Vector3(5, 0, 0); // ���Ͱ�, (x+5, y+0, z+0)
        // transform.Translate(vec);

    }

    void Update()
    {
        // ī�޶󿡵� �߰��ϸ� ���� ������
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // transform.Translate(vec);

        Vector3 vec = new Vector3( // Ű�� �̿��Ͽ� ������Ʈ �̵�
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 
            0);
        transform.Translate(vec);
    }
}