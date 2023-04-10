using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        // Time.deltaTime
        // 1�����Ӵ� �Һ�Ǵ� �ð�
        // ��ǻ���� ���ɿ� ���� �ɸ��� �������� �ð��� �����ϰ� �������ִ� ����
        // � ��ǻ�Ϳ��� �۵��ص� �����ϰ� �۵��ϵ��� ����� ��

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 
            0
            );

        transform.Translate(vec);

        // ��� 1. Translate : ���Ϳ� ���ϱ�
        // transform.Translate(vec * Time.deltaTime); // transform�� ����, Translation�� �Ÿ��� �̵�

        // ��� 2. Vector �Լ� : �ð� �Ű������� ���ϱ�
        // Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
    }
}
