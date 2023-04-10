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

    // 콜라이더: 게임 오브젝트의 경계 영역

    // OnTriggerEnter: 콜라이더 충돌이 시작할 때 호출되는 함수
    // OnTriggerStay: 콜라이더가 계속 충돌하고 있을 때
    // OnTriggerExit: 콜라이더 충돌이 끝날 때
    private void OnTriggerStay(Collider other) // 큐브 영역 진입 시
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse); // 위로 올라가도록 힘을 받음
    }
}
