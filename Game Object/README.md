# 게임 오브젝트 정리
  - 이동
    - position
  - 회전
    - rotation
  - 확대/축소
    - localScale // Scale
    
  - Transform 클래스
    - 물체의 위치를 이동하거나 회전할 때 사용
    - 동작
      - 이동
        - this.transform.Translate(이동 거리);
      - 회전
        - this.transform.Rotate(Ouaternion.Euler(회전축 * 회전각));
      - 확대/축소
        - this.transform.localScale = Vector3(sx, sy, sz);
        
----------------------------------------------------------------------

  - 모든 물체는 플랫폼 성능과 상관없이 항상 일정한 속도로 이동해야 함
    - 플랫폼에 따라 FPS(Frame Per Second)가 다름
      - 기기의 성능에 따른 이동 속도 차이를 고려
    - 속도 = 거리 / 시간 -> 거리 = 속도 * 시간
    
  - Time.deltaTime
    - 직전 프레임과 현재 프레임 사이의 소요시간 // 
    - [매 프레임 이동거리] = 속도 * TimedeltaTime
      - 빠른 기기
        - '매 프레임 이동거리'가 짧고, 이 이동거리를 높은 빈도로 움직임
      - 느린 기기
        - '매 프레임 이동거리'가 길고, 이 이동거리를 낮은 빈도로 움직임
        
----------------------------------------------------------------------

  - 방향에 따른 스크립트 표현 및 값
    - 전진 / Vector3.forward / Vector3(0, 0, 1)
    - 후진 / Vector3.back / Vector3(0, 0, -1)
    - 오른쪽 / Vector3.right / Vector3(1, 0, 0)
    - 왼쪽 / Vector3.left / Vector3(-1, 0, 0)
    - 위쪽 / Vector3.up / Vector3(0, 1, 0)
    - 아래 / Vector3.down / Vector3(0, -1, 0)
    - 원점 / Vector3.zero / Vector3(0, 0, 0)
    
----------------------------------------------------------------------

  - 벡터
    - 스칼라 : 크기만 있고 방향이 없음
      - 무게, 온도, ...
    - 벡터 : 크기와 방향이 함께 존재
      - 속도, 힘, ...
      - Vector2 : 2차원 평면벡터
      - Vector3 : 3차원 평면벡터
    
    - 좌표계 표현
      - 오른손 좌표계 (OpenGL)
      - 왼손 좌표계 (Unity)
      
----------------------------------------------------------------------

  - 물체의 회전
    - this.transform.Rotate(90.0f * Time.deltaTime, 0.0f 0.0f);
    - Rotate(x_angle, y_angle, z_angle)
      - 각 기본축을 중심으로 회전할 각도 지정
    - 90.0f * Time.deltatime
      - 1초에 90도 회전시킨다는 의미
      
----------------------------------------------------------------------

  - Rigidbody(물체에 물리적인 특성을 부여)
    - 외력으로 움직이려면 Rigidbody 컴포넌트를 추가해야 한다. 예) 중력, 마찰력 등
    - 키보드 등으로 움직이는 물체는 해당 없음
    
  - Rigidbody의 변수
  
    - Mass : 물체의 질량
    
    - Drag : 공기저항
    
    - Angular Drag : 회전운동저항
      - 마찰력과 유사한 움직임이지만 회전하는 물체에만 적용됨
      
    - Use Gravity : 중력의 영향 여부
      - 없으면 물체가 낙하하지 않음
      
    - Is Kinematic
      - 물체에 가해지는 힘의 크기와 방향 등을 계산하지 않음
        - 물리엔진 기능을 무효로
        - 충돌 체크는 여전히 수행
      - Transform을 통해서만 물체 조작 가능
      
    - Interpolate
      - 물체의 움직임이 지나치게 끊겨 보일 경우 사용
        - Interpolate / Extrapolate
      - 물체의 연속된 움직임을 계산하는 방식
        - None : 아무런 보정 없음
        - Interpolate : 이전/다음 프레임의 Transform을 기반으로 근사 (수식이 있다 쓰기 찾아보자 쓰기 귀찮아서)
        - Extrapolate : 이전/ 그 이전 프레임의 Transform을 기반으로 근사 (위와 동일)
        
    - Collision Detection
      - Discrete
        - 현재 프레임의 위치만으로 충돌 검사
        - Tunneling 문제
        
      - Continuous
        - 이전 프레임과 현재 프레임 사이의 이동 궤적을 바탕으로 충돌 검사
        - 안전적인 충돌 검사 가능
        - 계산량 증가
        - Rigidbody를 가진 물체엔 Discrete 충돌 검사, Rigidbody가 없는 물체엔 Continuous 충돌 검사
        
      - Continous Dynamic
        - Continuous 충돌 검사
          - Continuous나 Continuous Dynamic이 적용된 물체
          - Rigidbody가 없는 물체
        - Discrete가 적용된 물체엔 Discrete 충돌 검사
        - 압도적인 계산량
        
    - Constraints : 외력에 의한 움직임에 제약을 부여
      - Freeze Position
        - 선택된 축 방향 이동불가
      - Freeze Rotation
        - 선택된 축 중심 회전불가

----------------------------------------------------------------------

  - 물체에 탄성 추가
    - Assets -> Create -> Physic Material
    
    - Average, Minimum, Multiply, Maximum
      - 두 충돌 물체의 수치 중 평균/최소/곱/최대값을 이용
    
    - Drag 수치 조절
      - 튀어오르는 반동 조절
      - 0이면 저항이 없음
      
----------------------------------------------------------------------

  - 물체에 질감 부여
    - Create -> Material
    - Texture(사진도 사용가능)
    
----------------------------------------------------------------------

  - 사운드 출력
    - Add Component -> Audio -> Audio Source
    - Play On Awake : 연걸된 물체의 등장과 함께 소리 재생
    - Loop : 반복 재생
    - Priority : 우선 순위(0 : 최고, 256 : 최소, 128 : 기본값)
    - Pitch : 재생 속도
    
----------------------------------------------------------------------

  - 충돌 이벤트 처리
    - OnCollisionEnter()
      - 스크립트가 연결된 물체에 충돌 발생 시 호출되는 함수
        - 부딪힌 물체의 정보를 Collision 타입의 매개변수를 통해 전달
        - coll.gameObject 를 통해 부딪힌 물체를 제어
        
        예)
        void OnCollisionEnter(Collision coll)
        {
          GetComponent<AudioSource>().Play();
        }
  
    - OnCollisionEnter()
      - 충돌이 시작된 순간의 이벤트 처리
      
    - OnCollisionStay()
      - 충돌이 유지되고 있는 동안의 이벤트 처리
    
    - OnCollisionExit()
      - 충돌이 유지되고 있다가 끝나는 순간의 이벤트 처리
