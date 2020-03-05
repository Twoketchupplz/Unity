# RectTransformUtility
`RectTransform`에 관련된 메서드를 담고있는 클래스.
- - -


## Static Function
- `Bool` __RectangleContainsScreenPoint__  
    스크린상의 특정 포인트가 지정된 사각 범위 꼭지점 안에 포함되는지 bool을 리턴한다.
    ``` c#
    public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam);
    public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint);
    ```
    Parameter||
    --|--
    rect        | 지정할 `RectTransform`
    screenPoint | 포함 여부를 확인할 포인트
    cam (optional)| 메소드를 실행할 카메라
    
- - -