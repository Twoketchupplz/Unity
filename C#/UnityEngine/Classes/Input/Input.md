# Input
입력 시스템을 다루기 위한 클래스. `Input Manager`에 설정된 각 축을 읽고 모바일 장치의 멀티터치나 가속도계 데이터에 접근하는 경우 사용되는 클래스.

## Virtual Axes
"Horizontal"과 "Vertical"은 조이스틱에 매핑되어 있고, 'A, W, D, S'는 각 방향키, "Mouse X"와 "Mouse Y"는 마우스 델타에 매핑 되어있다. "Fire1", "Fire2", "Fire3"는 각각 Ctrl, Alt, Cmd키와 3개의 마우스 버튼 또는 조이스틱 버튼에 매핑 되어 있다. `Input Manager`에서 새로운 입력 축을 추가할 수 있다.

## Static Variables
- `int` touchCount  
    터치입력 횟수를 나타내며 프레임동안 변하지 않는다.
- - -



## Static Function

- `float` GetAxisRaw  
    ```c#
    public static float GetAxisRaw(string axisName);
    ```
    /axisName/에 의해 식별된 가상축의 값을 반환한다.
    키보드와 조이스틱의 입력값에 대해 -1 ~ 1까지의 값을 반환한다. 키보드는 정수 -1, 0, 1

- `bool` GetButton  
    ```c#
    public static bool GetButton(string buttonName);
    ```
    /buttonName/에 의해 식별된 가상 버튼을 누르고 있는 동안 눌러진 시간만큼 true를 반환한다. 액션 트리거 이벤트를 구현할때 사용한다. 연속적인 움직임을 제어할땐 `GetAxis`를 사용한다.

- `bool` GetButtonDown  
    ```c#
    public static bool GetButtonDown(string buttonName);
    ```
    /buttonName/에 의해 식별된 가상 버튼을 누르고 있는 프레임 동안 true를 반환한다. 매 프레임 재설정되므로 `Update`함수 내에서 이 함수를 호출해야 한다.

- `bool` GetButtonUp
    ```c#
    public static bool GetButtonUp(string buttonName);
    ```
    /buttonName/에 의해 식별된 가상 버튼을 떼었을 때 첫 프레임에 true를 반환한다.
    
- `Touch` GetTouch  
    ``` c#
    public static Touch GetTouch(int Index);
    ```
    특정한 터치 상태를 나타내는 오브젝트를 반환한다. 화면 터치시 화면을 터치한 순서대로 배열에 들어간다. 화면 3곳을 터치하면 index 0, 1, 2에 정보가 들어가고, 손을 떼는 부분은 `null`이 된다. 다시 이어서 터치하면 빈 index순으로 채워진다.

- - -