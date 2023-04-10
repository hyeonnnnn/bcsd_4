using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        // Time.deltaTime
        // 1프레임당 소비되는 시간
        // 컴퓨터의 성능에 따라 걸리는 프레임의 시간을 일정하게 보정해주는 역할
        // 어떤 컴퓨터에서 작동해도 일정하게 작동하도록 만들어 줌

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 
            0
            );

        transform.Translate(vec);

        // 방법 1. Translate : 벡터에 곱하기
        // transform.Translate(vec * Time.deltaTime); // transform의 방향, Translation의 거리로 이동

        // 방법 2. Vector 함수 : 시간 매개변수에 곱하기
        // Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
    }
}
