# Unity Learn Junior Programmer
유니티 공식 홈페이지 학습  
유니티 툴을 다루기 위함

## Unit 1 Player Control

### Lesson 1.1 : Start your 3D Engines
- F key
    - 오브젝트 포커싱
- Alt + wasd







---
### 22.01.14
### Lesson 1.2 : Pedal to the Metal

- Code
    - Start()
    - Update()
        - 매 프레임마다 호출
    - 물체의 움직임
    ```c#
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20); 
    }
    ```
    - 변수 `transform`은 선언 없이 사용 가능
        - C# 스크립트를 어느 오브젝트의 컴포넌트로 사용하는 경우, 그 오브젝트는 스크립트 내 선언 없이 접근 가능. (`using` 처럼)
    - `Transform.Translate(6 overload)`
        - 물체의 위치를 해당 벡터만큼 움직임
    - `Vector3.foward`
        - 0, 0, 1
        - 방향을 지정하는 의미이며, 크기는 다른 변수, 상수와 곱하여 사용
    - `Time.deltaTime`
        - 1sec/frame
        - 프레임 차이를 보정할 수 있음
        

- Component
    - `Mesh Collider`
        - 물체의 충돌을 조작
    - `Rigidbody`
        - 물체의 무게나, 중력 등을 조작
        - Mass는 무게/킬로그램

- 조작
    - ctrl + D
        - 하이어라키 상 오브젝트를 복제