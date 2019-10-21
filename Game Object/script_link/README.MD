# 다른 물체에 연결된 스크립트 

  - cube_script.cs를 Cube에 드래그하여 연결
  
  - sphere_transform.cs를 sphere에 연결해서 cube를 조작 가능
  
  - 동일한 코드는 하나만 적용되는게 아닌 중복 적용됨
  
    - 예) this.Transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
    - 위 코드가 다른 스크립트에 하나 더 있으면 속도가 더 빨라짐
