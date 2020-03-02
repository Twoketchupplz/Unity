# Rect Transform
UI 오브젝트의 위치나 각도, 크기 등의 정보를 관리한다.

|설정 항목          |기능|
|-------------------|---------------|
|Pos X, Pos Y, Pos Z|UI 오브젝트의 위치(Canvas에서 상대적인 위치).|
|Width              |UI 오브젝트의 넓이.|
|Height             |UI 오브젝트의 높이.|
|Anchors(Min, Max)  |UI 오브젝트를 배치할 떄의 기준점(0 ~ 1).|
|Pivot              |UI 오브젝트의 위치나 크기의 기준점. 조작 도구로 Rect 도구를 선택하면 표시된다.|
|Scale              |UI 오브젝트의 자체 크기. Width, Height로 설정한 크기를 비율로 설정한 값이다.|

- Pivot과 Anchor

    UI 오브젝트의 위치는 Anchor와 Pivot의 좌표로 정해진다.
    
    Pivot : UI 오브젝트를 배치할 때 '기준'이 되는 점.
        
    Anchor : Canvas에서 UI 오브젝트의 위치를 고정하는 기능. 실행되는 기기의 화면 비율이나 해상도가 변하면 Anchor를 기준으로 UI 오브젝트의 위치가 조정된다. Anchor는 Canvas 안쪽에 위치시켜야 한다. 
        
        - Stretch 모드 : 2개 이상의 지점을 정하여 UI 오브젝트를 해상도나 화면 비율에 맞춰 자동으로 늘려주는 모드. Anchor는 상하좌우로 나누에 배치할 수 있다. Anchor 프리셋에서 선택하거나 마우스로 드래그하여 나눈다.
    
