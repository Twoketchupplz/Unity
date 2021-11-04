# Canvas
UI Obj를 배치하기 위한 영역.

# Component

## Rect Transform
UI Obj의 위치나 각도, 크기 등의 정보를 관리.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;프로퍼티&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|기능 
--------------------------------|--
__Pos X, Y, Z__                 | UI의 위치(*Canvas*와 상대적인 위치).
__Width, Height__               | UI의 넓이와 높이를 설정.
__Right, Left, Top, Bottom__    | Margin 거리를 조정. Anchor를 설정할 경우 남.
__Anchors__                     | UI의 위치를 고정하는 기능.<br> UI를 배치할 때의 기준점(0 ~ 1). 실행되는 기기의 화면 비율이나 해상도가 변하면, Anchor를 기준으로 UI의 위치가 조정됨. Anchor는 *Canvas* 안쪽에 위치시켜야 함. 
Anchor Presets                  | 프리셋으로 앵커의 위치 지정 가능.
`+` Stretch 모드                | 2개 이상의 지점을 정하여 UI를 해상도나 화면 비율에 맞춰 자동으로 늘려주는 모드. 
`+` Min, Max                    | 
__Pivot__                       | UI의 위치나 크기의 '기준점'. 조작 도구로 Rect 도구를 선택시 나타남.
__Scale__                       | UI의 자체 크기. Width, Height로 설정한 크기를 비율로 설정한 값.

- - -



## Canvas
Renderer Mode에 따라 설정할 수 있는 항목 다름.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;프로퍼티&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | 기능
----------------|------------------
__Renderer Mode__       | 스크린 또는 월드 공간에 렌더링하기 위해 사용. 아래 3개의 드롭다운 메뉴가 있다.
Screen Space - OverLay  | *Canvas*를 화면에 맞춤.<br> UI 항목이 씬의 가장 상위계층으로 앞쪽에 표시. 씬이나 카메라에 상관없이 렌더링한다.
`+` Pixel Perfect       | UI가 확실하게 보이는 상태로 함.
`+` Sort Order          | *Canvas*들의 순서 설정.
`+` Target Display      | 그리는 카메라를 전환한다.
Screen Space - Camera   | *Canvas*를 카메라에 맞춤.<br> 카메라가 특정 레이어에 위치한 것처럼 렌더링. 씬을 표시하는 카메라 외에 UI를 표시하는 카메라를 추가할 수 있으며 그리기 순서를 조절해 Obj가 UI보다 앞에 보이게 할 수 있다.
`+` Pixel Perfect       | UI가 확실하게 보이는 상태로 한다.
`+` Render Camera       | UI용 카메라 설정. UI만 표시되도록 Layer를 설정해야 함.
`+` Plane Distance      | 카메라와 *Canvas*의 거리.
`+` Order in Layer      | 그리기 순서.
||(+ p193 culling Mask, Clear Flags...)
World Space             | *Canvas*의 위치와 크기를 자유롭게 설정.<br> *Canvas*가 일반 Obj처럼 인식된다. 위치와 크기는 Rect Transform 컴포넌트의 값을 변경한다.
`+` Event Camera        | UI에 이벤트 처리를 위한 설정 항목.
`+` Sorting Layer       | *Canvas*가 여러 개 있을 때 그룹으로 나눈다.
`+` Order in Layer      | 그리기 순서 지정.
__Additional Shader Channels__      | UI에 셰이더 채널 추가.
- - -



## Canvas Scaler
추가될 UI Obj의 크기를 조절한다.

프로퍼티   |기능 
---------------------|----------
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__UI Scale Mode__&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 환경에 따른 UI의 크기 조절 방법 설정. 
Constant Pixel Size             | 픽셀을 기준으로 크기 조절. 디바이스의 해상도나 화면 비율에 영향을 받지 않음. UI가 해상도에 맞춰 크기가 조정됨.
`+` Scale Factor                | 캔버스를 확대, 축소할 때의 비율.        
`+` Reference Pixels Per Unit   | Scale 1을 몇 픽셀로 나타낼지 설정.
Scale With Screen Size          | 스크린 크기에 따라 자동으로 UI를 확대 또는 축소한다.
`+` Reference Resolution        | UI가 표시될 디스플레이의 기준 해상도. 실제 디스플레이의 해상도가 이보다 높으면 UI도 크게, 낮으면 작게 표시.|
`+` Screen Match Mode           | 화면 비율이 Reference Resolution과 맞지 않을 때의 설정.|
`+` Match                       | Reference Resolution과 화면 비율이 맞지 않으면 Reference Resolution의 화면 비율을 Width와 Height 중 어느 쪽에 맞춰 조절할지 정한다.|
`+` Reference Pixels Per Unit   | 1 유닛을 몇 픽셀로 표시할지 정한다.|
Constant Physical Size          | 인치, 밀리미터 등 실제의 물리적 크기를 기준으로 UI의 크기를 조절한다.
`+` Physical Unit               | 센티미터, 밀리미터, 인치 등 물리적 크기의 단위|
`+` Fallback Screen DPI         | DPI(Dots Per Inch, 도트 밀도)의 측정이 필요하면 이 값을 적용|
`+` Default Sprite DPI          | 스프라이트의 1인치에 해당하는 픽셀 수|
`+` Reference Pixels Per Unit   | 1 유닛을 표시할 픽셀 수. Default Sprite DPI 설정에 사용|
- - -



## Graphic Raycaster


# 추가할 수 있는 Component
## Horizontal Layout Group (Script)
자식 Obj를 수평기준으로 정렬한다.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;프로퍼티&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|기능|
--|--
__Padding__             | 레이아웃 그룹 에지의 패딩.
__Spacing__             | 레이아웃 요소 간 간격.
__Child Alignment__     | 사용 가능한 공간을 모두 채우지 않을 경우 자식 레이아웃 요소에 사용할 얼라인먼트.
__Child Controls Size__ | 레이아웃 그룹이 자식의 너비와 높이를 제어할지 여부를 결정한다.
__Child Force Expand__  | 추가로 사용할 수 있는 공간을 채우기 위해 자식 레이아웃을 강제로 확장할지 여부를 결정한다.

- - -