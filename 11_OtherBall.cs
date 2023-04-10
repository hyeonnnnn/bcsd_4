using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh; // 오브젝트의 재질 접근
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // CollisionEnter: 물리적 충돌이 시작할 때 호출되는 함수
    // CollisionStay: 물리적 충돌이 진행되는 동안 호출되는 함수
    // CollisionExit: 물리적 충돌이 끝났을 때 호출되는 함수

    // 오브젝트가 My Ball과 충돌했을 때 호출 
    private void OnCollisionEnter(Collision collision) // Collision: 충돌 정보 클래스
    {
        if(collision.gameObject.name == "My Ball") 
            mat.color = new Color(0, 0, 0);     
    }
 
    // 오브젝트가 My Ball과 충돌이 끝났을 때 호출
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball") 
            mat.color = new Color(1, 1, 1);         
    }
}
