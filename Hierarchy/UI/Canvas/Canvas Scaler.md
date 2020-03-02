# Canvas Scaler
추가될 UI 오브젝트의 크기를 조절한다.

### UI Scale Mode

환경에 따른 UI 오브젝트의 크기 조절 방법을 선택한다.

- Constant Pixel Size
    
    UI 오브젝트의 크기는 픽셀 지정이 됩니다. 디바이스의 해상도나 화면 비율에 영향을 받지 않으므로 같은 UI 오브젝트도 해상도에 맞춰 크고 작아진다.
    
    |설정 항목                  |기능                                   |
    |---------------------------|---------------------------------------|
    |Scale Factor               |캔버스를 확대, 축소할 떄의 비율.        |
    |Reference Pixels Per Unit  |Scale 1을 몇 픽셀로 나타낼지 설정한다.|
        
- Scale With Screen Size

    스크린 크기에 따라 자동으로 UI 오브젝트를 확대 또는 축소한다.
    
    |설정 항목                   |기능                                                                                               |
    |---------------------------|---------------------------------------------------------------------------------------------------|
    |Reference Resolution       |UI가 표시될 디스플레이의 기준 해상도. 실제 디스플레이의 해상도가 이보다 높으면 UI도 크게, 낮으면 작게 표시된다.|
    |Screen Match Mode          |화면 비율이 Reference Resolution과 맞지 않을 때의 설정.|
    |Match                      |Reference Resolution과 화면 비율이 맞지 않으면 Reference Resolution의 화면 비율을 Width와 Height 중 어느 쪽에 맞춰 조절할지 정한다.|
    |Reference Pixels Per Unit  |1유닛을 몇 픽셀로 표시할지 정한다.|

- Constant Physical Size

    인치, 밀리미터 등 실제의 물리적 크기를 기준으로 UI 오브젝트의 크기를 조절한다
    
    |설정 항목                  |기능                                   |
    |---------------------------|---------------------------------------|
    |Physical Unit              |센티미터, 밀리미터, 인치 등 물리적 크기의 단위|
    |Fallback Screen DPI        |DPI(Dots Per Inch, 도트 밀도)의 측정이 필요하면 이 값을 적용|
    |Default Sprite DPI         |스프라이트의 1인치에 해당하는 픽셀 수|
    |Reference Pixels Per Unit  |1유닛을 표시할 픽셀 수. Default Sprite DPI 설정에 사용|
