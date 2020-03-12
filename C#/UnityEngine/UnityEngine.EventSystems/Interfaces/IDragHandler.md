# IDragHandler
OnDrag 콜백을 받기위한 인터페이스. 

## Public Function
- `void` OnDrag  
    드래그 대상이 드래그가 되는 동안 호출된다.
    ``` C#
    public void OnDrag(EventSystems.PointerEventData eventData) {

    }
    ```

    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터