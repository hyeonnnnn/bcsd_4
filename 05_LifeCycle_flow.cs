using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 1. 초기화
    void Awake() // 게임 오브젝트 생성할 때 자동 생성
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() // 업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // 2. 물리 (프레임)
    private void FixedUpdate() // 물리 연산 업데이트, 
    {                          // 고정된 실행 주기
        Debug.Log("이동~");
    }

    // 3. 게임 로직 (프레임)
    void Update() // 게임 로직 업데이트,
    {             // 환경에 따라 실행 주기가 떨어질 수 있음
        Debug.Log("몬스터 사냥!"); 
    }

    void LateUpdate() // 모든 업데이트가 끝난 후
    {
        Debug.Log("경험치 획득");
    }

    // 4. 해체
    private void OnDisable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
