# Sprite
2D 그래픽 오브젝트를 지칭한다.

# Component

## Transform

## Sprite Renderer
스프라이트를 렌더링하고 스프라이트가 프로젝트의 씬에 시각적으로 표시되는 방식을 제어합니다.

프로퍼티 | 기능
--|--
__Sprite__              | 렌더링할 스프라이트 텍스처를 정의한다. 오른쪽의 작은 점을 클릭하면 Object Picker 창이 열리며, 이용 가능한 스프라이트 에셋 리스트에서 선택할 수 있습니다.
__Color__               | 버텍스 컬러를 정의하여 스프라이트의 이미지에 색조를 더하거나 다른 컬러를 적용합니다. 컬러 피커에서 렌더링된 스프라이트 텍스처의 버텍스 컬러를 설정할 수 있습니다.
__Flip__                | 선택한 축에 있는 스프라이트 텍스처를 뒤집습니다. 하지만 게임 오브젝트의 Transform 포지션은 뒤집히지 않습니다.
__Material__            | 렌더링시 사용하는 머티리얼을 정의합니다.
__Draw Mode__           | 크기가 변할 때 스프라이트가 확대/축소되는 방식을 정의합니다. 드롭다운 상자에서 다음 옵션 중 하나를 선택할 수 있다.
&nbsp;&nbsp;Simple          | 크기가 변하면 전체 이미지가 확대/축소됩니다.
&nbsp;&nbsp;Sliced          | 스프라이트가 [9슬라이스](https://docs.unity3d.com/kr/current/Manual/9SliceSprites.html)일때 선택합니다. 코너는 같은 크기를 유지하고 나머지 부분은 적절히 스트레치 합니다.
&nbsp;&nbsp;&nbsp;&nbsp;size(width/height)  | 9슬라이스 스프라이트에 맞게 확대/축소되도록 새로운 너비값과 높이값을 입력받는다. Rect Transform 툴을 사용하여 스프라이트 크기를 조정하고 9슬라이싱 프로퍼티를 적용할 수도 있다.
&nbsp;&nbsp;Tiled           | 스프라이트가 [9슬라이스](https://docs.unity3d.com/kr/current/Manual/9SliceSprites.html)일때 선택합니다. 크기가 변할 때 스프라이트 중간이 확대/축소되지 않고 타일링됩니다. Tile Mode 를 사용하여 스프라이트의 타일링 동작을 제어할 수 있습니다.
&nbsp;&nbsp;&nbsp;&nbsp;Continuous          | 
&nbsp;&nbsp;&nbsp;&nbsp;Adaptive            | 
&nbsp;&nbsp;&nbsp;&nbsp;Stretch Value       | 
__Sorting Layer__       | 
__Order in Layer__      | 
__Mask Interaction__    | 
__Sprite Sort Point__   | 
__Material__            | 