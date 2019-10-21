using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_translate : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 5.0f;
    public float power = 500.0f;
    public GameObject ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = speed * Time.deltaTime;
        float vertical_input = Input.GetAxis("Vertical");
        float horizontal_input = Input.GetAxis("Horizontal");
        Vector3 launch_direction = new Vector3(0, 1, 1);

        transform.Translate(Vector3.forward * vertical_input * distance_per_frame);
        transform.Translate(Vector3.right * horizontal_input * distance_per_frame);

        if (Input.GetButtonDown("Fire1"))
        {
            ball.GetComponent<Rigidbody>().AddForce(launch_direction * power);
        }
      //  Debug.Log(Input.GetAxis("Vertical"));
      //  Debug.Log(Input.GetAxis("Horizontal"));
    }
}