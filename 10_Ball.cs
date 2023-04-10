using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // 컴포넌트 가져오기
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // GetComponent<T> : 자신의 T타입 컴포넌트를 가져옴
    }

    void FixedUpdate()
    {
        // 1. 속도 바꾸기
        // velocity : 현재 이동 속도
        // rigid.velocity = Vector3.right; // 단위벡터. 정해진 벡터값으로만 이동
        rigid.velocity = new Vector3(2, 4, 3); // 벡터 지정

        // 2. 힘으로 밀기
        // Mass 무게 값이 클수록 움직이는데 더 많은 힘이 필요
        // AddForce(Vec) : Vec의 방향과 크기로 힘을 줌
        // ForceMode : 힘을 주는 방식(가속, 무게 반영)
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            // Debug.Log(rigid.velocity); // AddForce의 힘 방향으로 계속 속도 velocity 증가
        }
        Vector3 vec = new Vector3
            (Input.GetAxisRaw("Horizontal"), 
            0, 
            Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. 회전력 주기 
        rigid.AddTorque(Vector3.back); // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김
    }       
}
