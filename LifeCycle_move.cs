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

        Vector3 vec = new Vector3(5, 0, 0); // 벡터값 
        transform.Translate(vec);
   
    }
}
