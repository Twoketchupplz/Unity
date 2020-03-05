# Component

게임 오브젝트에 첨부된 모든 컴포넌트의 기본 클래스.

코드에 의해 직접 컴포넌트가 생성되지 않는다. 대신 스크립트 코드를 기재하고, 스크립트를 `GameObject`에 연결한다.
- - -


## Variable
- `GameObject` __gameObject__  
    현재의 컴포넌트가 첨부된 게임 오브젝트를 나타낸다. 컴포넌트는 항상 게임 오브젝트에 첨부되어 있다.

- `String` __tag__  
    현재 게임 오브젝트의 태그를 나타낸다. 태그 매니저에서 태그를 정의되어야 사용 가능하다.
- `Transform` __transform__  
    현재 게임 오브젝트에 첨부된 트랜스폼을 나타낸다. 

- - -


## Public Function
- `void` __BroadcastMessage__  
    씬 계층상 현재 오브젝트의 모든 MonoBehaviour나 Children 들에 대해 "methodName" 으로 이름지어진 메서드를 호출한다.
    ``` c#
    public void BroadcastMessage(string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver);

    public void BroadcastMessage(string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver);

    public void BroadcastMessage(string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver);

    public void BroadcastMessage(string methodName, SendMessageOptions options);
    ```
    Parameter||
    --|--
    methodName|호출할 메서드 이름
    parameter|해당 메서드에 전달할 임의의 파라미터
    options|해당하는 메서드가 없을때 오류 발생에 대한 메시지. 인수를 넣지 않으면 무시할 수 있다. `SendMessageOptions.RequireReceiver`으로 지정하면 수신자를 찾을 수 없는 경우에, 콘솔에 오류가 출력된다.

    
- `T` __GetComponent__  
    게임 오브젝트의 컴포넌트를 가져온다. (제네릭 버젼)
    ``` c#
    public T GetComponent();
    ```
    Parameter||
    --|--
    T | 가져올 컴포넌트 유형

- - -