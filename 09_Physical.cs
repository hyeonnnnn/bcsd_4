/*
물체의 필수 요소 4가지
Mesh, RigidBody, Collider, Metarial

1. RigidBody (중력 작용)
    중력 작용을 받기 위한 컴포넌트

    Mass 수치가 높을수록 충돌이 무거워진다.
    Use Gravity는 중력을 받을지 말지 결정한다.
    Is Kinematic이 true이면 외부 물리 효과를 무시한다.

2. Collider (충돌 영역)
    충돌 물리 효과를 받기 위한 컴포넌트

3. Material
    오브젝트의 표면 재질을 결정하는 컴포넌트

    Metalic : 금속 재질 수치
    Smoothness : 빛 반사 수치
    Texture : 재질에 들어가는 이미지
    Tilling : 텍스쳐 반복 타일 개수
    Emission : 텍스쳐 밝기 조절

4. Physics Material
    탄성과 마찰을 다루는 물리적인 재질

    Bounciness : 탄성력
    Bounciness Combine :다음 탄성을 계산하는 방식
    Friction : 마찰력
    Friction Combine : 다음 마찰력을 계산하는 방식

 */