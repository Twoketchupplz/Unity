# IBeginDragHandler
OnBeginDrag 콜백을 받기위한 인터페이스. `IDragHandler`를 추가적으로 구현해야 한다.

## Public Function
- OnBeginDrag  
    드래그가 시작되기 전에 `BaseInputModule`에 의해 호출된다. 
    ``` C#
    void OnBeginDrag( PointerEventData eventData ) {
        
    }
    ```
    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터