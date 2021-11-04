# Canvas
UI 오브젝트를 배치하기 위한 영역.

# Component

## Rect Transform
UI 오브젝트의 위치나 각도, 크기 등의 정보를 관리한다.

프로퍼티     |기능 
--------------------------------|--
__Pos X, Pos Y, Pos Z__         | UI 오브젝트의 위치(Canvas에서 상대적인 위치).
__Width, Height__ | UI 오브젝트의 넓이와 높이를 설정한다.
__Right, Left, Top, Bottom__    | Anchor를 설정할 경우 나타난다. Margin 거리를 조정한다.
__Anchors__                     | UI 오브젝트를 배치할 떄의 기준점(0 ~ 1). Canvas에서 UI 오브젝트의 위치를 고정하는 기능이다. 실행되는 기기의 화면 비율이나 해상도가 변하면 Anchor를 기준으로 UI 오브젝트의 위치가 조정된다. Anchor는 Canvas 안쪽에 위치시켜야 한다. 
&nbsp;&nbsp;Anchor Presets      | 좌측의 그림을 클릭하면 엥커의 위치를 주어진 프리셋으로 쉽게 지정할 수 있다.
&nbsp;&nbsp;&nbsp;&nbsp;Stretch 모드        | 2개 이상의 지점을 정하여 UI 오브젝트를 해상도나 화면 비율에 맞춰 자동으로 늘려주는 모드. Anchor는 상하좌우로 나누어 배치할 수 있다. Anchor 프리셋에서 선택하거나 마우스로 드래그하여 나눈다.
&nbsp;&nbsp;&nbsp;&nbsp;Min, Max            | 
__Pivot__                       | UI 오브젝트의 위치나 크기의 '기준점'. 조작 도구로 Rect 도구를 선택하면 표시된다
__Scale__                       | UI 오브젝트의 자체 크기. Width, Height로 설정한 크기를 비율로 설정한 값이다.

    Anchor와 Pivot  
    UI 오브젝트의 위치는 Anchor와 Pivot의 좌표로 정해진다.
- - -



## Canvas
Renderer Mode에 따라 설정할 수 있는 항목이 달라진다.

&nbsp;&nbsp;&nbsp;프로퍼티&nbsp;&nbsp;&nbsp; | 기능
----------------|------------------
__Renderer Mode__| 스크린 또는 월드 공간에 렌더링하기 위해 사용된다. 아래 3개의 드롭다운 메뉴가 있다.
&nbsp;&nbsp;Screen Space - OverLay  | `Canvas`를 화면에 맞춘다.<br> `Canvas`의 크기 == 화면 크기. `Canvas`의 크기 != 카메라 크기<br> UI 항목이 씬의 가장 상위계층으로 앞쪽에 표시된다. 씬이나 카메라에 상관없이 렌더링한다. 선택시(default) 아래 항목들을 조정할 수 있다.
&nbsp;&nbsp;&nbsp;&nbsp;Pixel Perfect       | UI가 확실하게 보이는 상태로 한다.
&nbsp;&nbsp;&nbsp;&nbsp;Sort Order          |Canvas가 여러 개라면 순서를 설정한다.
&nbsp;&nbsp;&nbsp;&nbsp;Target Display      |카메라가 여러 대 있을 때 그리는 카메라를 전환한다.
||
&nbsp;&nbsp;Screen Space - Camera   | 마치 카메라가 특정 레이어에 위치한 것처럼 렌더링 된다. 씬을 표시하는 카메라 외에 UI를 표시하는 카메라를 추가할 수 있으며 그리기 순서를 조절해 오브젝트가 UI보다 앞에 보이게 할 수 있다. 선택시 아래 항목들을 조정할 수 있다.
&nbsp;&nbsp;&nbsp;&nbsp;Pixel Perfect       |UI가 확실하게 보이는 상태로 한다.
&nbsp;&nbsp;&nbsp;&nbsp;Render Camera       |UI용 카메라 설정. UI만 표시되도록 Layer를 설정해야 한다.
&nbsp;&nbsp;&nbsp;&nbsp;Plane Distance      |카메라와 Canvas의 거리.
&nbsp;&nbsp;&nbsp;&nbsp;Order in Layer      |그리기 순서를 설정한다.
||(+ p193 culling Mask, Clear Flags...)
||
&nbsp;&nbsp;World Space | Canvas가 일반 오브젝트처럼 인식된다. Canvas의 위치와 크기를 자유롭게 설정할 수 있다. 위치와 크기는 Rect Transform 컴포넌트의 값을 변경한다.  선택시 아래 항목들을 조정할 수 있다.
&nbsp;&nbsp;&nbsp;&nbsp;Event Camera        | UI에 이벤트 처리를 위한 설정 항목.
&nbsp;&nbsp;&nbsp;&nbsp;Sorting Layer       | Canvas가 여러 개 있을 때 그룹으로 나눈다.
&nbsp;&nbsp;&nbsp;&nbsp;Order in Layer      |그리기 순서를 설정한다.
__Additional Shader Channels__      | UI에 셰이더 채널을 추가합니다.
- - -



## Canvas Scaler
추가될 UI 오브젝트의 크기를 조절한다.

프로퍼티   |기능 
---------------------|----------
__UI Scale Mode__|환경에 따른 UI 오브젝트의 크기 조절 방법을 선택한다. 아래 3개의 드롭다운 메뉴를 선택할 수 있다.
&nbsp;&nbsp;Constant Pixel Size| UI 오브젝트의 크기는 픽셀 지정이 됩니다. 디바이스의 해상도나 화면 비율에 영향을 받지 않으므로 같은 UI 오브젝트도 해상도에 맞춰 크고 작아진다.
&nbsp;&nbsp;&nbsp;&nbsp;Scale Factor                |캔버스를 확대, 축소할 떄의 비율.        
&nbsp;&nbsp;&nbsp;&nbsp;Reference Pixels Per Unit   |Scale 1을 몇 픽셀로 나타낼지 설정한다.
&nbsp;&nbsp;Scale With Screen Size                  | 스크린 크기에 따라 자동으로 UI 오브젝트를 확대 또는 축소한다.
&nbsp;&nbsp;&nbsp;&nbsp;Reference Resolution        |UI가 표시될 디스플레이의 기준 해상도. 실제 디스플레이의 해상도가 이보다 높으면 UI도 크게, 낮으면 작게 표시된다.|
&nbsp;&nbsp;&nbsp;&nbsp;Screen Match Mode           |화면 비율이 Reference Resolution과 맞지 않을 때의 설정.|
&nbsp;&nbsp;&nbsp;&nbsp;Match                       |Reference Resolution과 화면 비율이 맞지 않으면 Reference Resolution의 화면 비율을 Width와 Height 중 어느 쪽에 맞춰 조절할지 정한다.|
&nbsp;&nbsp;&nbsp;&nbsp;Reference Pixels Per Unit   |1유닛을 몇 픽셀로 표시할지 정한다.
&nbsp;&nbsp;Constant Physical Size                  | 인치, 밀리미터 등 실제의 물리적 크기를 기준으로 UI 오브젝트의 크기를 조절한다.
&nbsp;&nbsp;&nbsp;&nbsp;Physical Unit               |센티미터, 밀리미터, 인치 등 물리적 크기의 단위|
&nbsp;&nbsp;&nbsp;&nbsp;Fallback Screen DPI         |DPI(Dots Per Inch, 도트 밀도)의 측정이 필요하면 이 값을 적용|
&nbsp;&nbsp;&nbsp;&nbsp;Default Sprite DPI          |스프라이트의 1인치에 해당하는 픽셀 수|
&nbsp;&nbsp;&nbsp;&nbsp;Reference Pixels Per Unit   |1유닛을 표시할 픽셀 수. Default Sprite DPI 설정에 사용|
- - -



## Graphic Raycaster


# 추가할 수 있는 Component
## Horizontal Layout Group (Script)
자식 오브젝트를 수평기준으로 정렬한다.

프로퍼티|기능|
--|--
__Padding__ | 레이아웃 그룹 에지의 패딩.
__Spacing__ | 레이아웃 요소 간 간격.
__Child Alignment__ | 사용 가능한 공간을 모두 채우지 않을 경우 자식 레이아웃 요소에 사용할 얼라인먼트.
__Child Controls Size__ | 레이아웃 그룹이 자식의 너비와 높이를 제어할지 여부를 결정한다.
__Child Force Expand__ | 추가로 사용할 수 있는 공간을 채우기 위해 자식 레이아웃을 강제로 확장할지 여부를 결정한다.

- - -