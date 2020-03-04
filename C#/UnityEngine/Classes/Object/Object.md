# Object

모든 오브젝트의 기본 클래스.  
`Object`로부터 상속된 `public` 변수들은 인스펙터 뷰에 보여지게 되며, GUI를 통해 값을 설정할 수 있다.

## Variable
- __hideFlags__  
    오브젝트가 숨겨져있는 상태인지, 씬에 저장된 상태인지, 또는 사용자에 의해서 수정가능한 상태인지를 확인한다.

- __name__
    오브젝트의 이름을 나타낸다. 컴포넌트는 게임 오브젝트, 첨부된 모든 컴포넌트와 같은 이름을 공유한다.
    ``` C#
    public string name;
    ```

## Public Function
- __GetInstanceID__
    오브젝트의 인스턴스 ID를 반환한다. ID는 항상 고유한 값을 가진다.
    ``` C#
    public int GetInstanceID();
    ```
- __ToString__
    게임 오브젝트의 이름을 반환한다.
    ``` C#
    public string ToString();
    ```

## Static Function
- __Destroy__
- 추가 바람

## Operator
- __bool__  
    오브젝트가 있으면 True 없으면 False