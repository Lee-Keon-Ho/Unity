using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_translate : MonoBehaviour
{
    //상위 계층에 연결해서 사용
    GameObject game_object;

    // Start is called before the first frame update
    void Start()
    {
        game_object = GameObject.Find("Cube") as GameObject; // 시작과 동시에 Cude 물체 찾아서 >> game_object
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            game_object.transform.parent = this.transform;
        }
        
        if(Input.GetKey(KeyCode.N))
        {
            game_object.transform.parent = null;
        }
        // game_object.transform.parent = hand.transform >> 특정 위치에 물체 연결, 부모와 자식관계, 상위와 하위, 아이템 장착 개념
        
        if(Input.GetMouseButtonDown(0))
        {
            game_object = GameObject.Find("Cube");
            Destroy(game_object);
        }
    }
}
