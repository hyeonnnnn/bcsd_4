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

        Vector3 vec = new Vector3(5, 0, 0); // ���Ͱ� 
        transform.Translate(vec);
   
    }
}
