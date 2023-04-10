using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 목표 위치를 (8, 1.5f, 0)으로
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // 1. MoveTowards() : 등속 이동, (현재 위치, 목표 위치, 속도)
        transform.position =
            Vector3.MoveTowards(transform.position, target, 2f);

        // 2. SmoothDamp() : 부드러운 감속 이동, (현재 위치, 목표 위치, 참조 속도, 속도)
        Vector3 velo = Vector3.zero; // (0, 0, 0)
                                     // static이기 때문에 new를 붙이지 X
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f); // ref: 참조 접근 -> 실시간으로 바뀌는 값 적용 가능

        // 3. Lerp() : 선형 보간 함수. 
        // SmoothDamp()보다 감속 시간이 더 긺, (현재 위치, 목표 위치, 속도)
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);

        // 4. Slerp() : 구면 선형 보간 함수.
        // 포물선 이동, (현재 위치, 목표 위치, 속도)
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }

}
