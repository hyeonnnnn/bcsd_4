using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        // Transform : 오브젝트 형태에 대한 기본 컴포넌트
        // 오브젝트는 변수 Transform을 항상 가지고 있음
        // 선언할 필요 X

        // Translate : 벡터 값을 '현재 위치에 더하는' 함수

        // Vector3 vec = new Vector3(5, 0, 0); // 벡터값, (x+5, y+0, z+0)
        // transform.Translate(vec);

    }

    void Update()
    {
        // 카메라에도 추가하면 같이 움직임
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // transform.Translate(vec);

        Vector3 vec = new Vector3( // 키를 이용하여 오브젝트 이동
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 
            0);
        transform.Translate(vec);
    }
}