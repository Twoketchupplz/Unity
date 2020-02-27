# **UI**
유니티 UI요소는 하이어라키 창에 오브젝트로 추가하여 씬에 배치한다.
Canvas는 UI 오브젝트를 배치하기 위한 영역이다. Canvas의 크기는 게임 뷰에 비례한다.
UI 오브젝트는 빛의 영향을 받지 않고, 정면에서 바라본 시점으로 표시된다.

### Canvas의 컴포넌트
- **Canvas**
  - Renderer Mode
    - Screen Space - OverLay
    
    UI가 가장 앞쪽에 표시된다. 다음과 같은 항목을 설정할 수 있다.
    
    Pixel Perfect   : UI가 확실하게 보이는 상태
    
    **Sort Order**      : Canvas가 여러 개라면 순서를 설정
    
    Target Display  : 카메라가 여러 대 있을 때 그리는 카메라를 전환
    
    Additional Shader Channels  : UI에 셰이더 채널을 추가합니다.

    
    - Screen Space - Camera
    
    씬을 표시하는 카메라 외에 UI를 표시하는 카메라를 추가할 수 있으며 그리기 순서를 조절해 오브젝트가 UI보다 앞에 보이게 할 수 있다.
    

