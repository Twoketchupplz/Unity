# Rigidbody 2D
오브젝트 물리엔진을 구현한다.

## 프로퍼티
프로퍼티 | 기능
-- | --
__Body Type__       | `Dynamic`, `Kinematic`, `Static` 3가지 드롭다운 옵션이있다. 위치, 회전과 같은 움직임과, Collider와 상호작용을 정의할 수 있다.
||
__Dynamic__     | 시뮬레이션에 따라 움직이도록 한다. 질량이나 중력, 포스 등의 프로퍼티를 설정할 수 있다.
Material                | 모든 2D 콜라이더에게 특정 재질을 지정한다.
Simulated               | 실행시간동안 Rigidbody 2D와 Collider 2Ds와 상호작용을 활성/비활성화 한다.
Use Auto Mass           | 체크시 Rigidbody 2D가 Collider 2D에서 게임 오브젝트의 Mass를 자동으로 감지한다.
Mass                    | Rigidbody 2D의 `Mass`를 정의한다. `Use Auto Mass` 체크시 비활성화된다.
Linear Drag             | 위치 이동에 영향을 미치는 계수
Angular Drag            | 회전 운동에 영향을 미치는 계수
Gravity Scale           | 게임 오브젝트가 중력의 영향을 받는 정도.
Collision Detection     | 콜라이더 간의 충돌이 감지되는 방식
&nbsp;&nbsp;Discrete        | Rigidbody와 Collider가 있는 게임 오브젝트가 충분히 빠르게 움직이는 경우 physic 업데이트 중에 서로 겹치거나 통과할 수 있다.
&nbsp;&nbsp;Continuous      | Rigidbody와 Collider가 있는 게임 오브젝트가 업데이트 중에 서로 통과하지 않는다. 이를 대신하여 콜라이더의 첫 번째 임팩트 포인트를 계산하여 게임 오브젝트를 그곳으로 이동시킨다. CPU 시간이 더 많이 걸린다.
Sleeping Mode           | 게임 오브젝트가 휴면 상태일 때 프로세서 시간을 절약하기 위해 휴면 상태를 다음 3개중 하나로 정의한다.
&nbsp;&nbsp;Never Sleep     | 휴면 모드가 비활성화 된다. 시스템 리소스에 영향을 줄 수 있으므로 가능한 피해야한다.
&nbsp;&nbsp;Start Awake     | 게임오브젝트는 휴면되어 있지 않은채로 시작한다.
&nbsp;&nbsp;Start Asleep    | 게임 오브젝트는 휴면 상태로 시작하나 충돌에 의해 풀릴 수 있다.
Interpolate             | 물리 업데이트 사이에 게임 오브젝트의 움직임이 보간되는 방식을 정의한다.(움직임이 불안정 할때 사용)
&nbsp;&nbsp;None            | 움직임 스무딩이 적용되지 않는다.
&nbsp;&nbsp;Interpolate     | 이전 프레임에서 게임 오브젝트의 위치에 따라 부드럽게 조정된다.
&nbsp;&nbsp;Extrapolate     | 다음 프레임에서의 위치 추정치를 기반으로 부드럽게 조정된다.
Constraints             | Rigidbody 2D의 모션에 대한 제한을 정의한다.
Freeze Position         | X와 Y축에서 위치이동을 중지한다.
Freeze Rotation         | Z축에서의 회전을 중지한다.
||
__Kinematic__   |
Material                | 모든 2D 콜라이더에게 특정 재질을 지정한다.
Simulated               | 실행시간동안 Rigidbody 2D와 Collider 2Ds와 상호작용을 활성/비활성화 한다.
Use Full Kinematic Contacts |
Collision Detection     | 콜라이더 간의 충돌이 감지되는 방식
&nbsp;&nbsp;Discrete        | Rigidbody와 Collider가 있는 게임 오브젝트가 충분히 빠르게 움직이는 경우 physic 업데이트 중에 서로 겹치거나 통과할 수 있다.
&nbsp;&nbsp;Continuous      | Rigidbody와 Collider가 있는 게임 오브젝트가 업데이트 중에 서로 통과하지 않는다. 이를 대신하여 콜라이더의 첫 번째 임팩트 포인트를 계산하여 게임 오브젝트를 그곳으로 이동시킨다. CPU 시간이 더 많이 걸린다.
Sleeping Mode           | 게임 오브젝트가 휴면 상태일 때 프로세서 시간을 절약하기 위해 휴면 상태를 다음 3개중 하나로 정의한다.
&nbsp;&nbsp;Never Sleep     | 휴면 모드가 비활성화 된다. 시스템 리소스에 영향을 줄 수 있으므로 가능한 피해야한다.
&nbsp;&nbsp;Start Awake     | 게임오브젝트는 휴면되어 있지 않은채로 시작한다.
&nbsp;&nbsp;Start Asleep    | 게임 오브젝트는 휴면 상태로 시작하나 충돌에 의해 풀릴 수 있다.
Interpolate             | 물리 업데이트 사이에 게임 오브젝트의 움직임이 보간되는 방식을 정의한다.(움직임이 불안정 할때 사용)
&nbsp;&nbsp;None            | 움직임 스무딩이 적용되지 않는다.
&nbsp;&nbsp;Interpolate     | 이전 프레임에서 게임 오브젝트의 위치에 따라 부드럽게 조정된다.
&nbsp;&nbsp;Extrapolate     | 다음 프레임에서의 위치 추정치를 기반으로 부드럽게 조정된다.
Constraints             | Rigidbody 2D의 모션에 대한 제한을 정의한다.
Freeze Position         | X와 Y축에서 위치이동을 중지한다.
Freeze Rotation         | Z축에서의 회전을 중지한다.
||
__Static__      |
