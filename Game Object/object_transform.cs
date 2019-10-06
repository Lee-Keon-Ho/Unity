using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 시작과 동시에 단 한번만 진행합니다.
    }

    // Update is called once per frame
    void Update()
    {
        // 매 프레임 마다 진행
        if(Input.GetKeyDown (KeyCode.A)){ // A키를 누르면 동작
            float rnd = Random.Range (-0.2f, 0.2f); // 랜덤 함수 사용
            this.transform.position += new Vecctor3 (rnd, rnd, rnd); // 램덤으로 받은 rnd를 이용해서 *이동*
        }
        
        if(Input.GetKeyDown (KeyCode.B)) { // B키를 누르면 동작
            float rnd = Random.Range (0.0f, 360.0f); // 랜덤 함수 사용
            this.transform.rotation = Quaternion.Euler (rnd, 0.0f, 0.0f); // 랜덤으로 받은 rnd를 *rotation x값에 적용*
        }
        
        if(Input.GetKeyDown (KeyCode.C)) { // C키를 누르면 동작
            float rnd = Random.Range (0.5f, 1.5f); // 랜덤 함수 사용
            this.transform.localScale = new Vector3 (rnd, rnd, rnd); // 랜덤으로 받은 rnd를 *localScale 값에 적용*
        }
        
        if(Input.GetKey(KeyCode.UpArrow)) { // 방향키 위
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime)); // z축 방향으로 이동
        }
        
        if(Input.GetKey(KeyCode.UpArrow)) { // 방향키 위
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime); // 앞으로 이동 (0, 0, 1) * 3
        }
    }
}
