# Input
입력 시스템을 다루기 위한 클래스. `Input Manager`에 설정된 각 축을 읽고 모바일 장치의 멀티터치나 가속도계 데이터에 접근하는 경우 사용되는 클래스.

## Virtual Axes
"Horizontal"과 "Vertical"은 조이스틱에 매핑되어 있고, 'A, W, D, S'는 각 방향키, "Mouse X"와 "Mouse Y"는 마우스 델타에 매핑 되어있다. "Fire1", "Fire2", "Fire3"는 각각 Ctrl, Alt, Cmd키와 3개의 마우스 버튼 또는 조이스틱 버튼에 매핑 되어 있다. `Input Manager`에서 새로운 입력 축을 추가할 수 있다.

## Static Variables
- `int` touchCount  
    터치입력 횟수를 나타내며 프레임동안 변하지 않는다.
- - -



## Static Function
- `Touch` GetTouch  
    특정한 터치 상태를 나타내는 오브젝트를 반환한다.
    ``` c#
    public static Touch GetTouch(int Index);
    ```

    화면 터치시 화면을 터치한 순서대로 배열에 들어간다. 화면 3곳을 터치하면 index 0, 1, 2에 정보가 들어가고, 손을 떼는 부분은 `null`이 된다. 다시 이어서 터치하면 빈 index순으로 채워진다.

- - -