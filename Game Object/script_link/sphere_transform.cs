using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_translate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            GameObject game_object = GameObject.Find("Cube") as GameObject;
            game_object.GetComponent<cube_script> ().scale_up();
        }
    }
}
