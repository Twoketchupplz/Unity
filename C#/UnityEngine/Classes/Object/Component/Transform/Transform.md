# Transform
게임 오브젝트의 위치, 회전, 스케일을 저장하고 다룬다.
- - -


## Variable
- `Int` __childCount__  
    트랜스폼이 가진 자식 트랜스폼의 수를 반환한다.

- `Transform` __parent__  
    트랜스폼 오브젝트의 부모 트랜스폼을 반환한다.

- `Transform` __root__  
    계층 가장 위에있는 트랜스폼을 반환한다.

- `Vector3` __position__  
    월드 공간에서 트랜스폼의 위치를 반환한다.

- - -


## Public Function
- `int` __GetSiblingIndex__  
    형제 중 이 오브젝트의 인덱스를 가져온다.

- `void` __SetAsFirstSibling__  
    이 오브젝트의 인덱스를 첫번째로 변경한다.

- `void` __SetAsLastSibling__
    이 오브젝트의 인덱스를 마지막으로 변경한다.

- `void` __SetSiblingIndex__  
    이 오브젝트의 인덱스를 지정한다.
    ``` c#
    public void SetSiblingIndex(int index);
    ```
    Parameter||
    ---|---
    index | 지정할 인덱스
