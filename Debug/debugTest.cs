using UnityEngine;
using System.Collections;

public class debugTest : MonoBehaviour {

  int i = 0;
  
  void Start () {
    Debug.Log (i++); // 시작과 동시에 단 한번만
  }
  
  
  void Update () {
    Debug.Log (i++); // 매 프레임 마다 호출됨
    
    /*
    Vector3 pos;
    pos = this.gameObject.transform.position;
    
    Debug.Log (pos); // 매 프레임 마다 position 정보 출력
    */
  }
}
