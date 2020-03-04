# EndDragHandler
OnEndDrag 콜백을 받기 위한 인터페이스. 드래그 종료시 호출된다. `IDragHandler`를 추가적으로 구현해야 한다.

## Public Function
- OnEndDrag  
    드래그 종료 시 `BaseInputModule`에 의해 호출된다.
    ``` C# 
    public void OnEndDrag(EventSystems.PointerEventData eventData) {

    }
    ```
    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터