# Cube를 움직여서 Sphere에 부딪히면, Sphere가 (0, 1, 1) 방향으로 발사되도록 구현
    -Cube와 Sphere 모두 Rigidbody 추가
    -Cube의 움직임은 화살표 키로
    -부딪혀온 방향에 상관없이 무조건 (0, 1, 1) 방향으로 …

# 힌트
  -OnCollisionEnter()
  -coll.gameObject.GetComponent
  -Plane은 AddForce()를 적용해도 발사되지 않음
  -Rigidbody 가 없으므로
