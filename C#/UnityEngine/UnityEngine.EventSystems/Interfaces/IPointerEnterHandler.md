# IPointerEnterHandler

OnPointerEnter 콜백을 받기 위한 인터페이스.

## Public Functions
- `void` OnPointerEnter  
    포인터가 오브젝트에 들어왔을 때 호출된다.

    ``` c#
    public void OnPointerEnter(EventSystems.PointerEventData eventData) {

    }
    ```

    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터