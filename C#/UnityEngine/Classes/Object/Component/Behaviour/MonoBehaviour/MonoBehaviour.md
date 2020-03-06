# MonoBehaviour
모든 스크립트가 상속받는 기본 클래스.

C#은 명시적으로 MonoBehaviour를 상속받아야 한다. 비활성화 하는 인스펙터 뷰에서 체크박스를 해제하는 경우 Start(), Awake(), Update(), FixedUpdate(), 와 OnGUI()의 수행을 막는다.
- - -



 ## Variable
 - `bool` __useGUILayout__  
    비활성화 하는 경우 GUI 레이아웃 페이즈를 생략한다. GUI 오버헤드를 줄여준다.
- - -



## Public Function
- `void` __CancelInvoke__  
    현재 MonoBehabiour상의 모든 `invoke` 호출을 취소한다.

- `void` __Invoke__  
    설정한 시간 뒤에 methodName 메서드를 호출한다.
    ``` c#
    public void Invoke(string methodName, float time);
    ```

- `void` __InvokeRepeating__  
    time 초 뒤에 methodName 메서드를 호출한 후, 매 repeatRate 초마다 반복적으로 메서드를 호출한다.
    ``` c#
    public void InvokeRepeating(string methodName, float time, float repeatRate);
    ```

- `bool` __IsInvoking__  
    현재 MonoBehaviour에서 보류 상태의 invoke 호출이 있는지 확인한다.
    ``` c#
    public bool IsInvoking(string methodName);
    ```

- `Coroutine` __StartCoroutine__  
    코루틴을 시작한다.
    
    간략히 코루틴을 설명하면 일반적인 함수와 달리 진입할 수 있는 진입점과, 빠져나오는 탈출점이 여러개인 함수이다.(협력형 멀티태스킹, 동시성 프로그래밍 지원, 비동기 처리 지원)
    ``` c#
    public Coroutine StartCoroutine(IEnumerator routine);
    ```

- `void` __StopAllCoroutines__  
    현재 Behaviour상의 모든 코루틴의 동작을 멈춘다.

- `void` __StopCoroutine__  
    현재 Behaviour상에서 파라미터에 명시한 첫번째 코루틴 동작을 멈춘다.
    ``` c#
    public void StopCoroutine(string methodName);  
    public void StopCoroutine(IEnumerator routine);
    ```
    Parameter||
    --|--
    methodName| 코루틴 이름
    routine | 코드 안 함수 이름
- - -



## Static Function
- `void` __print__  
    콘솔로 로그 메시지를 보낸다. `Debug.Log`와 동일.
    ``` c#
    public static void print(object message);
    ```
- - -



## Message
다음은 `Script Lifecycle FlowChart` 이다.

![플로우](https://docs.unity3d.com/kr/530/uploads/Main/monobehaviour_flowchart.svg)

- __Reset__  
    기본 설정값으로 리셋한다.
    
    유니티창 인스펙터에 리셋 버튼을 누르거나, 컴포넌트가 처음 연결되었을 때 스크립트의 프로퍼티로 초기화하는 데 호출된다.

- __Awake__  
    스크립트 인스턴스가 로딩될 때 호출된다.
    
    항상 `Start` 함수의 이전과 프리팹의 인스턴스화 직후에 호출된다. 활성화되거나 연결된 하나의 스크립트 함수가 호출될 때까지, `Awake`는 호출되지 않는다.

- __OnEnable__  
    오브젝트가 활성화된 경우에만 호출된다.

    `MonoBehaviour` 인스턴스가 생성될 때(레벨 로드 또는 스크립트 컴포넌트에 연결된 게임 오브젝트가 인스턴스화 될 때) 발생한다.

- __OnLevelWasLoaded__  
    새 레벨(Scene)이 로드 되었을때 호출된다.
    ```c#
    void OnLevelWasLoaded(int level);
    ```
- __Start__  

- __OnAplicationPause__  

