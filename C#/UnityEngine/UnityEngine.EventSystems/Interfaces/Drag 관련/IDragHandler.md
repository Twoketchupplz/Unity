# IDragHandler
OnDrag 콜백을 받기위한 인터페이스. 

## Public Function
- OnDrag  
    드래그가 발생하는 경우, 커서가 움직일 때마다 호출된다.
    ``` C#
    public void OnDrag(EventSystems.PointerEventData eventData) {

    }
    ```

    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터