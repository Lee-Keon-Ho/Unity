using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_reset : MonoBehaviour
{
    private Vector3 v1 = new Vector3(1f,0.5f,2f);
    private Vector3 v2 = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        // 시작과 동시에 단 한번만 진행합니다.
        
        if(Input.GetKey (KeyCode.Alpha2)){
          Debug.Log("2(@) is pressed!!"); // 키보드 2를 입력시 log창에 "2(@) is pressed!!" 출력이지만 Start에 있어서 미출력
         }
    }

    // Update is called once per frame
    void Update()
    {
        // 매 프레임 마다 진행
        
        if(Input.GetKey (KeyCode.Alpha2)){
          Debug.Log("2(@) is pressed!!"); // 키보드 2를 입력시 log창에 "2(@) is pressed!!" 출력
         }
    }
}
