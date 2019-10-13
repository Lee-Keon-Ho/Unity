# 입력 관련 정리

마우스 버튼 (Edit -> Project Settings -> Input)
-mouse 0 : 왼쪽 버튼
-mouse 1 : 오른쪽 버튼
-mouse 2 : 가운데 버튼


# Input.GetMouseButton(BUTTON)
  - Input.GetMouseButtonDown()
  - Input.GetMouseButtonUp()


# Input.mousePosition
  - 화면상에서 마우스 포인터의 위치를 반환 (0, 0)

-------------------------------------------------------------

키입력 / 매 프레임마다 호출되는 Update()에서 처리됨
 - 키를 언제 누르더라도 대응 가능하도록

-------------------------------------------------------------

Input 클래스
  - 사용자의 키 입력을 판정하는 클래스
    - Input.GetAxis("Horizontal"): 좌우 이동키의 이동 방향
    - Input.GetAxis("Vertical"): 앞뒤 이동키의 이동 방향
    - Input.GetKeyDown(): 특정한 키를 눌렀는지 여부 // 키보드
    - Input.GetButtonDown(): 특정한 키나 버튼을 눌렀는지 여부 // 키보드x, 콘솔 동
    - Input.GetMouseButtonDown(): 마우스버튼을 눌렀는지 여부
    - Input.GetTouch(): 터치스크린 화면을 눌렀는지 여부
    
# Input.GetAxis()
  - 입력장치(키보드, 마우스, 조이스틱)가 눌려진 해당 방향을 -1, 0, 1 로 알려준다.
  
# Input.GetAxis("Horizontal");
  - "a" -> -1, "b" -> 1
# Input.GetAxis("Vertical");
  - "w" -> -1, "s" -> 1
  
# Input.GetKey(KEYCODE)
  - 키보드의 특정 키가 눌렸는지 판정(True/False)
    - KeyCode.Space // 스페이스바
    - KeyCode.Return // 엔터 (옛날에는 Enter가 아닌 Return으로 표기 했었다고 합니다.)
    - KeyCode.UpArrow // 화살표 방향키 (위)
    - KeyCode.DownArrow // 화살표 방향키 (아래)
    - KeyCode.LeftArrow // 화살표 방향키 (왼쪽)
    - KeyCode.RightArrow // 화살표 방향키 (오른쪽)
    - KeyCode.Escape // ESC
    - KeyCode.BackSpace // 백스페이스
    - KeyCode.X // x, a~z 까지 가능
    - KeyCode.S // s, a~z 까지 가능
    - KeyCode.LeftShift // 왼쪽 쉬프트
    - KeyCode.RightShift // 오른쪽 쉬프트
    - KeyCode.LeftControl // 왼쪽 컨트롤
    - KeyCode.RightControl // 오른쪽 컨트롤
    - KeyCode.Alpha1 // 1(!), 1 ~ 0 까지 가능
    - KeyCode.F1 // F1, F1 ~ F12 까지 가능
    
# Input.GetKeyDown(KEYCODE)
  - 특정 키가 눌린(KeyDown) 순간에만
  
# Input.GetKeyUp(KEYCODE)
  - 특정 키에서 손가락이 떨어진(KeyUp) 순간에만
  
# Input.anyKeyDown
  - 아무 키나 눌린 순간에만
