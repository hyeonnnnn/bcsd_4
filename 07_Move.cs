using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // ��ǥ ��ġ�� (8, 1.5f, 0)����
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // 1. MoveTowards() : ��� �̵�, (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        transform.position =
            Vector3.MoveTowards(transform.position, target, 2f);

        // 2. SmoothDamp() : �ε巯�� ���� �̵�, (���� ��ġ, ��ǥ ��ġ, ���� �ӵ�, �ӵ�)
        Vector3 velo = Vector3.zero; // (0, 0, 0)
                                     // static�̱� ������ new�� ������ X
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f); // ref: ���� ���� -> �ǽð����� �ٲ�� �� ���� ����

        // 3. Lerp() : ���� ���� �Լ�. 
        // SmoothDamp()���� ���� �ð��� �� ��, (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);

        // 4. Slerp() : ���� ���� ���� �Լ�.
        // ������ �̵�, (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }

}
