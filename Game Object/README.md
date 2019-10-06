# 게임 오브젝트 정리
  - 이동
    - position
  - 회전
    - rotation
  - 확대/축소
    - localScale // Scale
    
  -Transform 클래스
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
