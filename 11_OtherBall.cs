using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh; // ������Ʈ�� ���� ����
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // CollisionEnter: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    // CollisionStay: ������ �浹�� ����Ǵ� ���� ȣ��Ǵ� �Լ�
    // CollisionExit: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�

    // ������Ʈ�� My Ball�� �浹���� �� ȣ�� 
    private void OnCollisionEnter(Collision collision) // Collision: �浹 ���� Ŭ����
    {
        if(collision.gameObject.name == "My Ball") 
            mat.color = new Color(0, 0, 0);     
    }
 
    // ������Ʈ�� My Ball�� �浹�� ������ �� ȣ��
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball") 
            mat.color = new Color(1, 1, 1);         
    }
}
