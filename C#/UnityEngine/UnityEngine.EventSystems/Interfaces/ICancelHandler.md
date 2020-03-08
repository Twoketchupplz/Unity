# ICancelHandler
OnCancel 콜백을 받기위한 인터페이스.

## Public function
- `void` OnCancel
    취소 이벤트가 발생했을 때 호출된다.  
    ``` C#
    public void OnCancel (EventSystems.BaseEventData eventData); {

    }
    ```

    Parameter   ||
    --          |--
    eventData   | 현재의 이벤트 데이터
