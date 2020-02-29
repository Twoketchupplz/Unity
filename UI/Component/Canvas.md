# Canvas
### Renderer Mode

- Screen Space - OverLay
    
    UI가 가장 앞쪽에 표시된다. 다음과 같은 항목을 설정할 수 있다.
      
    |설정 항목                   |기능                                            |
    |---------------------------|------------------------------------------------|
    |Pixel Perfect              | UI가 확실하게 보이는 상태로 한다.                |
    |Sort Order                 |Canvas가 여러 개라면 순서를 설정한다.             |
    |Target Display             |카메라가 여러 대 있을 때 그리는 카메라를 전환한다.  |    
    |Additional Shader Channels |UI에 셰이더 채널을 추가한다.                      |

    
- Screen Space - Camera
  
    씬을 표시하는 카메라 외에 UI를 표시하는 카메라를 추가할 수 있으며 그리기 순서를 조절해 오브젝트가 UI보다 앞에 보이게 할 수 있다.

    |설정 항목                   |기능                                                 |
    |---------------------------|-----------------------------------------------------|
    |Pixel Perfect              |UI가 확실하게 보이는 상태로 한다.                      |
    |Render Camera              |UI용 카메라 설정. UI만 표시되도록 Layer를 설정해야 한다.|
    |Plane Distance             |카메라와 Canvas의 거리.                               |
    |Order in Layer             |그리기 순서를 설정한다.                                |
    |Additional Shader Channels |UI에 셰이더 채널을 추가한다.                           |
  
    (+ p193 culling Mask, Clear Flags...)
    
    
- World Space
   
    Canvas의 위치와 크기를 자유롭게 설정할 수 있다. 위치와 크기는 Rect Transform 컴포넌트의 값을 변경한다.
 
    |설정 항목                   |기능                                      |
    |---------------------------|------------------------------------------|
    |Event Camera               |UI에 이벤트 처리를 위한 설정 항목.          |
    |Sorting Layer              |Canvas가 여러 개 있을 때 그룹으로 나눈다.   |
    |Order in Layer             |그리기 순서를 설정한다.                    |
    |Additional Shader Channels |UI에 셰이더 채널을 추가합니다.             |
