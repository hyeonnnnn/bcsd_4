using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 1. �ʱ�ȭ
    void Awake() // ���� ������Ʈ ������ �� �ڵ� ����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    private void OnEnable() // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void Start() // ������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    // 2. ���� (������)
    private void FixedUpdate() // ���� ���� ������Ʈ, 
    {                          // ������ ���� �ֱ�
        Debug.Log("�̵�~");
    }

    // 3. ���� ���� (������)
    void Update() // ���� ���� ������Ʈ,
    {             // ȯ�濡 ���� ���� �ֱⰡ ������ �� ����
        Debug.Log("���� ���!"); 
    }

    void LateUpdate() // ��� ������Ʈ�� ���� ��
    {
        Debug.Log("����ġ ȹ��");
    }

    // 4. ��ü
    private void OnDisable() // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
